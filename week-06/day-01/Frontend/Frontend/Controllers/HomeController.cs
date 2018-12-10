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
            if (input == 0)
            {
                return new Doubling { Error = "Please provide an input!" };
            }

            return new Doubling { Received = input, Result = input * 2 };
        }

        [HttpGet("greeter")]
        public ActionResult<Greeter> Greeter(string name, string title)
        {
            if (name == null)
            {
                return new Greeter { Error = "Please provide a name!" };
            }
            else if (title == null)
            {
                return new Greeter { Error = "Please provide a title!" };
            }

            return new Greeter { Name = name, Title = title, Welcome_message = $"Oh, hi there {name}, my dear {title}!" };
        }

        [HttpGet("appenda/{appendable}")]
        public ActionResult<Appenda> Appenda(string appendable)
        {
            if (appendable == null)
            {
                return NotFound();
            }

            return new Appenda { Appendable = appendable, Appended = appendable + "a" };
        }

        [HttpPost("dountil/{act}")]
        public ActionResult<Dountil> Dountil(string act, int number)
        {
            if (number == 0)
            {
                return new Dountil { Error = "Please provide a number!" };
            }
            else if (act == "sum")
            {
                return new Dountil { Action = "sum", Until = number, Result = frontendServices.Sum(number) };
            }
            else if (act == "factor")
            {
                return new Dountil { Action = "factor", Until = number, Result = frontendServices.Factor(number) };
            }

            return new Dountil();
        }

        [HttpPost("arrays")]
        public ActionResult<Arrays> Arrays(string what, int[] numbers)
        {
            if (what == null)
            {
                return new Arrays { Error = "Please provide what to do with the numbers!" };
            }
            else if (numbers == null)
            {
                return new Arrays { Error = "Please provide numbers!" };
            }

            return new Arrays();
        }
    }
}