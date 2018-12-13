using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TrialExam.Models;
using TrialExam.Services;

namespace TrialExam.Controllers
{
    [Route("api")]
    [ApiController]
    public class ApiController : ControllerBase
    {
        private readonly ISpaceTransporterServices spaceTransporterServices;

        public ApiController(ISpaceTransporterServices spaceTransporterServices)
        {
            this.spaceTransporterServices = spaceTransporterServices;
        }

        [HttpGet("top-planets")]
        public ActionResult<PlanetsCollection> TopPlanets()
        {
            var planets = spaceTransporterServices.FindAllPlanets().OrderByDescending(x => x.Population).Take(3);

            return new PlanetsCollection { Planets = planets};
        }
    }
}