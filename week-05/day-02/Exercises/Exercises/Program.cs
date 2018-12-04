using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            // ex1
            //            var result = n.Where(x => x % 2 == 0);

            // ex2
            //            var result = n.Where(x => x % 2 != 0).Average();

            // ex3
            //            var result = n.Where(x => x > 0).Select(x => x * x);

            // ex4
            //            int[] a = new[] { 3, 9, 2, 8, 6, 5 };
            //
            //            var result = a.Where(x => x * x > 20);

            // ex5
            //            int[] b = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };
            //
            //            var result = b.GroupBy(x => x);
            //
            //            foreach (IGrouping<int, int> num in result)
            //            {
            //                Console.WriteLine($"Frequency of {num.Key}: {num.Count()}");
            //
            //                foreach (var i in num)
            //                {
            //                    Console.WriteLine(" " + i);
            //                }
            //            }

            // ex6
            //            string aString = "asufhuihrohpukshpfuihaoghpuiahpgijagh";
            //
            //            var result = aString.GroupBy(x => x);
            //
            //            foreach (IGrouping<char, char> num in result)
            //            {
            //                Console.WriteLine($"Frequency of {num.Key}: {num.Count()}");
            //                
            //                foreach (var i in num)
            //                {
            //                    Console.WriteLine(" " + i);
            //                }
            //            }

            // ex7
            //            string[] cities = { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };
            //            var result = cities.Where(x => x.StartsWith("A") || x.EndsWith("I")).OrderBy(x => x);
            //            foreach (var city in result)
            //            {
            //                Console.WriteLine(city);
            //            }

            // ex8
            //            string aString = "sdfYIGuiihiGYGYGhiIIiuug";
            //            var result = aString.Where(x => x > 64 && x < 91);
            //            foreach (var letter in result)
            //            {
            //                Console.WriteLine(letter);
            //            }

            // ex9
            //            char[] charArray = new[] {'a', 'r', 't', 'o'};
            //            var result = String.Join("", charArray.Select(x => x));
            //            Console.WriteLine(result);

            // ex10
            //            List<Fox> foxList = new List<Fox>()
            //            {
            //                new Fox {Color = "yello", Name = "fox1", Type = "type1"},
            //                new Fox {Color = "green", Name = "fox2", Type = "type4"},
            //                new Fox {Color = "blue", Name = "fox3", Type = "pallida"},
            //                new Fox {Color = "green", Name = "fox4", Type = "pallida"},
            //                new Fox {Color = "white", Name = "fox5", Type = "type3"}
            //            };
            //
            //            var greenFoxs = foxList.Where(x => x.Color.Equals("green")); // foxes with green color.
            //            var greenPallidaFoxes = foxList.Where(x => x.Color.Equals("green") && x.Type.Equals("pallida"));
            //
            //            foreach (var greenFox in greenFoxs)
            //            {
            //                Console.WriteLine($"Name: {greenFox.Name} Color: {greenFox.Color}");
            //            }
            //
            //            Console.WriteLine("---");
            //
            //            foreach (var greenPallidaFox in greenPallidaFoxes)
            //            {
            //                Console.WriteLine($"Name: {greenPallidaFox.Name} Color: {greenPallidaFox.Color} Type: {greenPallidaFox.Type}");
            //            }

            // ex11
            //            var result = String.Join("", File.ReadAllText(
            //                        @"C:\Users\Jimmy_Zhu\Projects\dotnet-academy\greenfox\zhuqh93\week-05\day-02\Exercises\Exercises\data.txt")
            //                           .Where(x => x == 32 || (x > 64 && x < 91) || (x > 96 && x < 123) || (x > 47 && x < 58)))
            //                             .Split(' ')
            //                               .GroupBy(x => x)
            //                                .OrderByDescending(x => x.Count())
            //                                 .ThenBy(x => x.Key).Take(100);
            //            
            //            foreach (var x in result)
            //            {
            //                Console.WriteLine($"{x.Key}: {x.Count()}");
            //            }

            // ex12
            var temp1 = File.ReadAllLines(
                @"C:\Users\Jimmy_Zhu\Projects\dotnet-academy\greenfox\zhuqh93\week-05\day-02\Exercises\Exercises\swcharacters.txt")
                .Where();


            Console.Read();
        }
    }

    class Fox
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Color { get; set; }
    }
}
