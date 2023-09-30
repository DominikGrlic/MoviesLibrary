using Microsoft.AspNetCore.Mvc;
using CinemaProject.Data;
using System;
using CinemaProject.Data.Services;
using CinemaProject.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;

namespace CinemaProject.Controllers
{
    public class ActorController : Controller
    {
        //-- DEPENDENCY INJECTION
        private readonly IActorService _actorService;

        
        public ActorController(IActorService actorService)
        {
            _actorService = actorService;
        }


        public async Task<IActionResult> Index()
        {
            var data = await _actorService.GetAllAsync();

            ViewBag.errormsg = TempData["errorMsg"] as string ?? string.Empty;

            return View(data);
        }


        // GET Actor/Create
        public IActionResult Create()
        {
            ViewBag.errormsg = TempData["errorMsg"] as string ?? string.Empty;
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(
            [Bind("Id,FullName,ProfileImageUrl,Bio")]Actor actor,
            IFormFile ProfileImageUrl,
            int movieId
            )
        {
            if(movieId <= 0)
            {
                TempData["errorMsg"] = "Pick one movie!";
                return RedirectToAction(nameof(Create));
            }

            var modelErrors = new List<string>();

            if(ModelState.IsValid)
            {
                try
                {
                    var imageName = ProfileImageUrl.FileName.ToLower();
                    var saveImagePath = Path.Combine(
                        Directory.GetCurrentDirectory(),
                        "wwwroot/images/actors",
                        imageName
                        );

                    Directory.CreateDirectory(Path.GetDirectoryName(saveImagePath));

                    using (var stream = new FileStream(saveImagePath, FileMode.Create))
                    {
                        ProfileImageUrl.CopyTo(stream);
                    }

                    actor.ProfileImageUrl = imageName;

                }
                catch (Exception ex)
                {
                    TempData["errorMsg"] = ex.Message;
                    return RedirectToAction(nameof(Create));
                }

                _actorService.Add(actor);

                Actor_Movie actor_Movie = new Actor_Movie();
                actor_Movie.MovieId = movieId;
                actor_Movie.ActorId = actor.Id;

                _actorService.AddConnectionTable(actor_Movie);

                return RedirectToAction("Index");
            }
            else
            {
                foreach(var modelState in ModelState.Values)
                {
                    foreach(var error in modelState.Errors)
                    {
                        modelErrors.Add(error.ErrorMessage);
                    }
                }

                TempData["errorMsg"] = String.Join("<br />", modelErrors);
                return RedirectToAction(nameof(Create));
            }
        }


        // GET: Actors/Deatils/id
        public IActionResult Details(int id)
        {
            var actor = _actorService.GetById(id);

            if(actor == null)
            {
                return NotFound();
            }

            return View(actor);
        }


        public ActionResult Edit(int id)
        {
            var editActor = _actorService.GetById(id);

            if(editActor == null)
            {
                return NotFound();
            }

            if(id == 0)
            {
                return NotFound();
            }

            ViewBag.errormsg = TempData["errorMsg"] as string ?? string.Empty;

            return View(editActor);
        }

        [HttpPost]
        public async Task<ActionResult> Edit(
            [Bind("Id,FullName,ProfileImageUrl,Bio")] Actor actor,
            int id,
            IFormFile? newImage,
            int movieId)
        {
            if(id == 0)
            {
                return NotFound();
            }

            if(movieId == 0)
            {
                TempData["errorMsg"] = "Pick one movie.";
                return RedirectToAction(nameof(Edit), new { id = id });
            }

            
            
            if (ModelState.IsValid)
            {
                if (newImage != null)
                {
                    var newImageName = newImage.FileName.ToLower().Replace(" ", "_");
                    var saveImagePath = Path.Combine(
                        Directory.GetCurrentDirectory(),
                        "wwwroot/images/actors",
                        newImageName);

                    Directory.CreateDirectory(Path.GetDirectoryName(saveImagePath));

                    using (var stream = new FileStream(saveImagePath, FileMode.Create))
                    {
                        newImage.CopyTo(stream);
                    }

                    actor.ProfileImageUrl = newImageName;
                }

                await _actorService.EditAsync(id, actor);

                _actorService.RemoveRangeOfActorMovies(id);

                Actor_Movie actor_Movie = new Actor_Movie();
                actor_Movie.MovieId = movieId;
                actor_Movie.ActorId = id;

                return RedirectToAction(nameof(Index));
            }

            return View(actor);

        }

        // GET: Actors/Delete/1
        public ActionResult Delete(int id)
        {
            var deleteActor = _actorService.GetById(id);

            if (deleteActor == null)
            {
                return NotFound();
            }

            if (id == 0)
            {
                return NotFound();
            }

            return View(deleteActor);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            if(id == 0)
            {
                throw new Exception(string.Format("Wrong actor ID."));
            }

            _actorService.Delete(id);

            return RedirectToAction(nameof(Index));
        }


    }
}
