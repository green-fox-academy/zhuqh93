using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoxPet.Reporsitories
{
    public class Fox
    {
        public string Name { get; set; }
        public List<string> Tricks { get; set; }
        public string Food { get; set; }
        public string Drink { get; set; }
        public static int Id { get; private set; } = -1;

        public Fox(string name)
        {
            this.Name = name;
            this.Tricks = new List<string>();
            this.Food = "normal food";
            this.Drink = "normal drink";
            Id++;
        }
    }
}
