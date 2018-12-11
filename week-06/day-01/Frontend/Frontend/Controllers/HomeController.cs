using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Frontend.Models;
using Frontend.Services;
using Microsoft.AspNetCore.Mvc;

namespace Frontend.Controllers
{
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IFrontendServices frontendServices;

        public HomeController(IFrontendServices frontendServices)
        {
            this.frontendServices = frontendServices;
        }

        [HttpGet("")]
        public ActionResult Index()
        {
            return File("index.html", "text/html");
        }

        [HttpGet("doubling")]
        public ActionResult<Doubling> Doubling([FromQuery] int input)
        {
            if (input == 0) return new Doubling { Error = "Please provide an input!" };

            return new Doubling { Received = input, Result = input * 2 };
        }

        [HttpGet("greeter")]
        public ActionResult<Greeter> Greeter(string name, string title)
        {
            if (string.IsNullOrWhiteSpace(name)) return new Greeter { Error = "Please provide a name!" };
            if (string.IsNullOrWhiteSpace(title)) return new Greeter { Error = "Please provide a title!" };

            return new Greeter { Name = name, Title = title, Welcome_message = $"Oh, hi there {name}, my dear {title}!" };
        }

        [HttpGet("appenda/{appendable}")]
        [HttpGet("appenda")]
        public ActionResult<Appenda> Appenda(string appendable)
        {
            if (string.IsNullOrWhiteSpace(appendable)) return NotFound();

            return new Appenda { Appendable = appendable, Appended = appendable + "a" };
        }

        [HttpPost("dountil/sum")]
        public ActionResult<Dountil> Sum(Dountil dountil)
        {
            if (dountil.Until == 0) return new Dountil { Error = "Please provide a number!" };

            return new Dountil { Result = frontendServices.Sum(dountil.Until) };
        }

        [HttpPost("dountil/factor")]
        public ActionResult<Dountil> Factor(Dountil dountil)
        {
            if (dountil.Until == 0) return new Dountil { Error = "Please provide a number!" };

            return new Dountil { Result = frontendServices.Factor(dountil.Until) };
        }

        [HttpPost("arrays")]
        public ActionResult<Arrays> Arrays(Arrays array)
        {
            if (string.IsNullOrWhiteSpace(array.What) || (array.Numbers == null)) return new Arrays { Error = "Please provide what to do with the numbers!" };

            if (array.What.Equals("sum")) return new Arrays { Result = frontendServices.Sum(array.Numbers) };

            if (array.What.Equals("multiply")) return new Arrays { Result = frontendServices.Multiply(array.Numbers) };

            if (array.What.Equals("double")) return new Arrays { Result = frontendServices.Double(array.Numbers) };

            return BadRequest("Invalid operation.");
        }
    }
}