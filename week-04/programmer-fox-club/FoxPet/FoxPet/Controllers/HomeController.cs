using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoxPet.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace FoxPet.Controllers
{
    public class HomeController : Controller
    {
        public static int index;
        public static List<Fox> foxList = new List<Fox>();

        [HttpGet("/")]
        public IActionResult Information()
        {
            if (foxList.Count == 0)
            {
                return RedirectToAction(nameof(Login));
            }

            return View(foxList[index]);
        }

        [HttpGet("/login")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost("/login")]
        public IActionResult Login(string name)
        {
            if (name == null || foxList.Contains(foxList.Find(x => x.Name.Equals(name))))
            {
                return RedirectToAction(nameof(Login));
            }

            foxList.Add(new Fox(name));

            foreach (var fox in foxList)
            {
                if (fox.Name.Equals(name))
                {
                    index = Fox.Id;
                }
            }

            return RedirectToAction(nameof(Information), new { name = foxList[index].Name });
        }
    }
}