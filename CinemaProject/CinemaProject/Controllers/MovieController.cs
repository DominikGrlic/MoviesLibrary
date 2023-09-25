using Microsoft.AspNetCore.Mvc;
using CinemaProject.Data;
using System;
using Microsoft.EntityFrameworkCore;

namespace Movie_project.Controllers
{
    public class MovieController : Controller
    {
        private readonly ApplicationDbContext _context;
        public MovieController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _context.Movies.Include(m => m.Cinema).OrderBy(m => m.Name).ToListAsync();
            return View(data);
        }
    }
}
