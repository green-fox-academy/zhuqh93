using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SayHelloToTheWorld.Models;

namespace SayHelloToTheWorld.Controllers
{
    [Route("Index")]
    public class HomeController : Controller
    {
        [HttpGet("Hello")]
        public IActionResult Index()
        {

            var hello = new Hello();
            Random rnd = new Random();
            Color randomColor = new Color();
            hello.FontColor = new List<Color>();

            for (int i = 0; i < hello.hellos.Length; i++)
            {
                int alpha = rnd.Next(0, 256);
                int red = rnd.Next(0, 256);
                int green = rnd.Next(0, 256);
                int blue = rnd.Next(0, 256);
            
                randomColor = Color.FromArgb(alpha, red, green, blue);

                if (!hello.FontColor.Contains(randomColor))
                {
                    hello.FontColor.Add(randomColor);
                }
            }

            for (int i = 0; i < hello.hellos.Length; i++)
            {
                Console.WriteLine(hello.hellos[i]);
            }

            return View(hello);
        }
    }
}