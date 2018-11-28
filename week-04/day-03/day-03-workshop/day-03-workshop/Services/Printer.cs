using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace day_03_workshop.Services
{
    public class Printer : IPrinter
    {
        public void Log(string message)
        {
            Console.WriteLine(" --- " + DateTime.Now + " MY PRINTER SAYS --- " + message);
        }
    }
}
