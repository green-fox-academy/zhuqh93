﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace week_04_day_01_workshop.Controllers
{
    public class HomeController : Controller
    {
        /*
        public IActionResult Index()
        {
            return View();
        }
        */

        [Route("")]
        public string Index()
        {
            return "Hello from the Controller!";
        }
    }
}