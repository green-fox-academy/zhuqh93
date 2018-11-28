using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using day_02_workshop.Models;
using Microsoft.AspNetCore.Mvc;

namespace day_02_workshop.Controllers
{
    public class HomeController : Controller
    {
        public static List<BankAccount> charactersList = new List<BankAccount>()
        {
            new BankAccount("Nala", 1500, "Lion", false, true),
            new BankAccount("Timon", 1000, "Meerkat", false, true),
            new BankAccount("Simba", 2000, "Lion", true, true),
            new BankAccount("Pumbaa", 1000, "Warthog", false, true),
            new BankAccount("Scar", 2000, "Lion", false, false)
        };

        [HttpGet("/show")]
        public IActionResult BankAccount()
        {
            return View(charactersList.Find(x => x.Name.Equals("Simba")));
        }

        [HttpGet("/string")]
        public IActionResult ShowString()
        {
            return View();
        }

        [HttpGet("")]
        public IActionResult ShowCharacters()
        {
            return View(charactersList);
        }

        [HttpGet("/update")]
        public IActionResult RaiseBalance()
        {
            return View();
        }

        [HttpPost("update")]
        public IActionResult RaiseBalance(string name)
        {
            foreach (var VARIABLE in charactersList)
            {
                if (VARIABLE.Name == name)
                {
                    if (VARIABLE.IsKing)
                    {
                        VARIABLE.Balance += 100;
                    }
                    else
                    {
                        VARIABLE.Balance += 10;
                    }
                }
            }
            

            return RedirectToAction(nameof(ShowCharacters));
        }
    }
}