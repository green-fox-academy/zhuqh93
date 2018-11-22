using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace workshop
{
    class Program
    {
        static void Main(string[] args)
        {
            char u = 'u';
            string aString = "uieudcc";
            string[] a = aString.Split(u);
            foreach (var VARIABLE in a)
            {
                Console.WriteLine(VARIABLE);
            }

            Console.WriteLine(string.Join(u+"U"+u, a));

            Console.Read();
        }
    }
}
