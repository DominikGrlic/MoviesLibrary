using Microsoft.AspNetCore.Mvc;
using CinemaProject.Data;
using System;
using CinemaProject.Data.Services;

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
        public async Task<IActionResult> Create()
        {

            return View();
        }
    }
}
