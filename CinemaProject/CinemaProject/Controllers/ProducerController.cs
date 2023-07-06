using Microsoft.AspNetCore.Mvc;
using CinemaProject.Data;
using System;

namespace Movie_project.Controllers
{
    public class ProducerController : Controller
    {
        private readonly ApplicationDbContext _context;
        public ProducerController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var data = _context.Producers.ToList();
            return View(data);
        }
    }
}
