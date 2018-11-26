using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FirstWebApplication.Controller
{
    public class HomeController : Microsoft.AspNetCore.Mvc.Controller
    {
        [Route("/")]
        public IActionResult Index()
        {
            return Redirect("/name/2");
        }

        // GET /name?name=Peter
        [HttpGet("/name")]
        public string Name([FromQuery]string name)
        {
            return $"Hi {name}!";
        }

        // GET /name/1
        [HttpGet("/name/{id}")]
        public string Id([FromRoute]long id)
        {
            return $"Your ID is {id}!";
        }
    }
}
