using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Practice_7._2.Models;
using System;

namespace Practice_7._2.Controllers
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
            ViewData["Title"] = "Животные эндемики";
            var animals = MemoryDb.Animals;
            return View(animals);
        }

        [HttpGet]
        public IActionResult Create()
        {
            Animal animal = new() { Id = Guid.Empty};
            return View(animal);
        }

        [HttpPost]
        public IActionResult Create(Animal animal)
        {
            if (ModelState.IsValid)
            {
                if (MemoryDb.Animals.Find(f => f.Id == animal.Id) == null)
                {
                    animal.Id = Guid.NewGuid();
                    MemoryDb.Animals.Add(animal);
                }
                else
                {
                    MemoryDb.Animals.Remove(MemoryDb.Animals.Find(f => f.Id == animal.Id));
                    MemoryDb.Animals.Add(animal);
                }
                return RedirectToAction("Index");
            }
            else
                return View();
        }

        [HttpGet]
        public IActionResult Delete(Animal animal)
        {
            if (ModelState.IsValid)
            {
                MemoryDb.Animals.Remove(animal);
            }
            return View();
        }

        [HttpGet]
        public IActionResult Edit(Animal animal)
        {
            return View("Create", animal);
        }
    }
}
