using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoxPet.Models;
using FoxPet.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Query.ExpressionTranslators.Internal;

namespace FoxPet.Controllers
{
    public class HomeController : Controller
    {
        private readonly IFoxServices FoxServices;

        public HomeController()
        {
            FoxServices = new FoxServices();
        }

        [HttpGet("/")]
        public IActionResult Information(string name)
        {
            if (name == null)
            {
                return RedirectToAction("Login");
            }
            
            var currentFox = FoxServices.Find(name);

            return View(currentFox);
        }

        [HttpGet("/login")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost("/login")]
        public IActionResult Login(string name)
        {
            if (name == null)
            {
                return RedirectToAction("Login");
            }
            else if (!FoxServices.Contains(FoxServices.Find(name)))
            {
                FoxServices.Add(name);
                return RedirectToAction("Login");
            }

            return RedirectToAction("Information", new { name = name });
        }
    }
}