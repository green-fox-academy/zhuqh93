using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace day_03_workshop.Repositories
{
    public class Red : IColor
    {
        private string name = "red";
        public void PrintColor()
        {
            Console.WriteLine($"It is {name} in color...");
        }
    }
}
