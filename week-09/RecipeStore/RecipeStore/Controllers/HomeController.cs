using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RecipeStore.Models;
using RecipeStore.Services;

namespace RecipeStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHomeServices _homeServices;

        public HomeController(IHomeServices homeServices)
        {
            _homeServices = homeServices;
        }

        [HttpGet("/")]
        public IActionResult Index()
        {
            var recipes = _homeServices.FindAll();

            return View(recipes);
        }

        [HttpGet("/create_recipe")]
        public IActionResult CreateRecipe()
        {
            return View();
        }

        [HttpPost("/create_recipe")]
        public IActionResult CreateRecipe97679679()
        {
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
