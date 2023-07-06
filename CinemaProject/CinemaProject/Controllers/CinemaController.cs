using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CinemaProject.Data;
using System;

namespace CinemaProject.Controllers
{
    public class CinemaController : Controller
    {
        private readonly ApplicationDbContext _context;
        public CinemaController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            //var cinemas = _context.Cinemas.ToListAsync();
            return View(await _context.Cinemas.ToListAsync());
        }
    }
}
