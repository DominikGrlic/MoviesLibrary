using Microsoft.AspNetCore.Mvc;
using CinemaProject.Data;
using System;

namespace CinemaProject.Controllers
{
    public class ActorController : Controller
    {
        private readonly ApplicationDbContext _context;
        public ActorController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var data = _context.Actors.ToList();
            return View(data);
        }
    }
}
