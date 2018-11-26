using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using week_04_day_01_workshop.Models;

namespace week_04_day_01_workshop.Controllers
{
    [Route("web")]
    public class WebController : Controller
    {
        private static int _webCounter;

        [HttpGet("greeting")]
        public IActionResult Greeting(string name)
        {
            _webCounter++;
            var greeting = new Greeting()
            {
                Id = _webCounter,
                Content = $", {name}! This site was loaded {_webCounter} times since last server start."
            };

            return View(greeting);
        }
    }
}