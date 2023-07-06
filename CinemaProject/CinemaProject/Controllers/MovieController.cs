using Microsoft.AspNetCore.Mvc;
using CinemaProject.Data;
using System;

namespace Movie_project.Controllers
{
    public class MovieController : Controller
    {
        private readonly ApplicationDbContext _context;
        public MovieController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var data = _context.Movies.ToList();
            return View(data);
        }
    }
}
