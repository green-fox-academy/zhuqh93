using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using week_04_day_01_workshop.Models;

namespace week_04_day_01_workshop.Controllers
{
    [Route("api")]
    public class RestController : Controller
    {
        private static int _apiCounter;
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("greeting")]
        public Greeting Greet(string name)
        {
            _apiCounter++;
            Greeting newGreet = new Greeting();
            newGreet.Id = _apiCounter;
            newGreet.Content = "Hello, " + name + "!";
            return newGreet;
        }
    }
}