using System;
using Microsoft.AspNetCore.Mvc;
using MyWeb.Models;

namespace MyWeb.Controllers
{
    public class AnimalController : Controller
    {


        private static List<AnimalViewModel> animals = new List<AnimalViewModel>();

        public IActionResult Index()
        {
            //AnimalViewModel animal = new AnimalViewModel()
            return View(animals);
        }

        public IActionResult Create()
        {
            var animal = new AnimalViewModel();
            return View(animal);
        }

        public IActionResult CreateAnimal(AnimalViewModel animal)
        {
            animals.Add(animal);
            return RedirectToAction(nameof(Index));
        }
       
        public string Hello()
        {
            return "Who's there";
        }
    }
}

