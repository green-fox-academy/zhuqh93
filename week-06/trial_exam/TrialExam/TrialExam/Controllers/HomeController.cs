using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TrialExam.Models;
using TrialExam.Services;
using TrialExam.ViewModels;

namespace TrialExam.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISpaceTransporterServices spaceTransporterService;

        public HomeController(ISpaceTransporterServices spaceTransporterService)
        {
            this.spaceTransporterService = spaceTransporterService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            SpaceTransporterViewModel model = spaceTransporterService.CreatViewModel();

            return View(model);
        }

        [HttpPost("movehere/{id}")]
        public IActionResult MoveHere(long id)
        {
            spaceTransporterService.MoveShipToPlanet(id);

            return RedirectToAction("Index");
        }

        [HttpGet("toship")]
        public IActionResult ToShip()
        {
            spaceTransporterService.MovePeopleToShip();

            return RedirectToAction("Index");
        }

        [HttpGet("toplanet")]
        public IActionResult ToPlanet()
        {
            spaceTransporterService.MovePeopleToPlanet();

            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
