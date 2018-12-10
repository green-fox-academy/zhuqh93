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

        public HomeController()
        {
            frontendServices = new FrontendServices();
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
        public ActionResult<Appenda> Appenda(string appendable)
        {
            if (string.IsNullOrWhiteSpace(appendable)) return NotFound();

            return new Appenda { Appendable = appendable, Appended = appendable + "a" };
        }

        [HttpPost("dountil/sum")]
        public ActionResult<Dountil> Sum(int number)
        {
            if (number == 0) return new Dountil { Error = "Please provide a number!" };

            return new Dountil { Until = number, Result = frontendServices.Sum(number) };
        }

        [HttpPost("dountil/factor")]
        public ActionResult<Dountil> Factor(int number)
        {
            if (number == 0) return new Dountil { Error = "Please provide a number!" };

            return new Dountil { Until = number, Result = frontendServices.Factor(number) };
        }

        [HttpPost("arrays")]
        public ActionResult<Arrays> Arrays(string what, int[] numbers)
        {
            if (string.IsNullOrWhiteSpace(what) || (numbers == null)) return new Arrays { Error = "Please provide what to do with the numbers!" };

            if (what.Equals("sum")) return new Arrays { What = what, Result = frontendServices.Sum(numbers) };

            if (what.Equals("muliply")) return new Arrays { What = what, Result = frontendServices.Multiply(numbers) };

            if (what.Equals("double")) return new Arrays { What = what, Result = frontendServices.Double(numbers) };

            return BadRequest("Invalid operation.");
        }
    }
}