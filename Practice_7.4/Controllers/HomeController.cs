using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Practice_7._4.Models;
using System;

namespace Practice_7._4.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewData["Title"] = "Известные музыканты";
            var musicians = MemoryDb.Musicians;
            return View(musicians);
        }

        [HttpGet]
        public IActionResult Create()
        {
            Musician musician = new() { Id = Guid.Empty };
            return View(musician);
        }

        [HttpPost]
        public IActionResult Create(Musician musician)
        {
            if (ModelState.IsValid)
            {
                if (MemoryDb.Musicians.Find(f => f.Id == musician.Id) == null)
                {
                    musician.Id = Guid.NewGuid();
                    MemoryDb.Musicians.Add(musician);
                }
                else
                {
                    MemoryDb.Musicians.Remove(MemoryDb.Musicians.Find(f => f.Id == musician.Id));
                    MemoryDb.Musicians.Add(musician);
                }
                return RedirectToAction("Index");
            }
            else
                return View();
        }

        [HttpPost]
        public IActionResult Delete(Musician musician)
        {
            if (ModelState.IsValid)
            {
                MemoryDb.Musicians.Remove(MemoryDb.Musicians.Find(f => f.Id == musician.Id));
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(Musician musician)
        {
            return View("Create", musician);
        }
    }
}
