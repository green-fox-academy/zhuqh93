using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FoxPet.Controllers
{
    public class FoxController : Controller
    {
        List<Food> foodList = new List<Food>();

        [HttpGet("/nutritionStore")]
        public IActionResult NutritionStore()
        {
            return View(HomeController.foxList[HomeController.index]);
        }

        [HttpPost("/nutritionStore")]
        public IActionResult NutritionStore(string food, string drink)
        {
            ViewBag = foodList;
            HomeController.foxList[HomeController.index].Food = food;
            HomeController.foxList[HomeController.index].Drink = drink;

            return RedirectToAction("Information", new {Controller = "Home", Action = "Information", name = HomeController.foxList[HomeController.index].Name});
        }

        [HttpGet("/trickCenter")]
        public IActionResult TrickCenter()
        {
            return View(HomeController.foxList[HomeController.index]);
        }

        [HttpPost("/trickCenter")]
        public IActionResult TrickCenter(string trick)
        {
            HomeController.foxList[HomeController.index].Tricks.Add(trick);

            return RedirectToAction("Information", new { Controller = "Home", Action = "Information", name = HomeController.foxList[HomeController.index].Name });
        }
    }
}