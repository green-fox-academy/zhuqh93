using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoxPet.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ActionConstraints;

namespace FoxPet.Services
{
    public class FoxServices : IFoxServices
    {
        public List<Fox> FoxList { get; }

        public FoxServices()
        {
            FoxList = new List<Fox>();
        }

        public void Add(string name) => FoxList.Add(new Fox {Name = name, Drink = "", Food = "", Tricks = new List<string>()});

        public Fox Find(string name) => FoxList.Find(x => x.Name.Equals(name));

        public bool Contains(Fox fox) => FoxList.Contains(fox);
    }
}
