using Microsoft.AspNetCore.Mvc;
using CinemaProject.Data;
using System;
using CinemaProject.Data.Services;
using CinemaProject.Models;

namespace CinemaProject.Controllers
{
    public class ActorController : Controller
    {
        private readonly IActorService _actorService;
        public ActorController(IActorService actorService)
        {
            _actorService = actorService;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _actorService.GetAll();
            return View(data);
        }

        // GET Actor/Create
        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("FullName,ProfileImageUrl,Bio")]Actor actor)
        {
            if (!ModelState.IsValid)
            {
                return View(actor);
            }

            _actorService.Add(actor);
            return RedirectToAction("Index");
        }
    }
}
