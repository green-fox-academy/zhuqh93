using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace week_04_day_01_workshop.Models
{
    public class Greeting
    {
        public long Id { get;  set; }
        public string Content { get;  set; }
        
        public Greeting()
        {
            Console.WriteLine($"id:{Id},content:{Content}");
        }
    }
}
