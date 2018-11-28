using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using day_03_workshop.Services;
using Microsoft.AspNetCore.Mvc;

namespace day_03_workshop.Controllers
{
    public class HomeController : Controller
    {
        private UtilityService utilityService = new UtilityService();

        [HttpGet("/useful")]
        public IActionResult Index()
        {
            return RedirectToAction(nameof(ColoredPage));
        }

        [HttpGet("/useful/colored")]
        public IActionResult ColoredPage()
        {
            return View();
        }
    }
}