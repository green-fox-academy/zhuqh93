using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.CompilerServices;

namespace day03_workshop
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            CoOrds coord = new CoOrds(0, 0);
            coord.Fill();
            coord.Closest();
            */

            Participant newParticipant = new Participant();
            newParticipant.Name = "Poor guy";
            newParticipant.Price = (new Random()).Next(1000, 10001);
            Console.WriteLine("{0} price: {1} {2}", newParticipant.Name, Prize.Amount, Prize.Currency);

            Console.Read();
        }

        public struct CoOrds
        {
            private int x;
            private int y;
            private List<CoOrds> coordstList;
            
            public CoOrds(int x, int y)
            {
                this.x = x;
                this.y = y;
                this.coordstList = new List<CoOrds>();
            }

            public void Fill()
            {
                Random rnd = new Random();

                for (int i = 0; i < 20; i++)
                {
                    this.x = rnd.Next(101);
                    this.y = rnd.Next(101);
                    coordstList.Add(new CoOrds(x, y));
                }
            }

            public void Closest()
            {
                double distance = Math.Sqrt(Math.Pow((coordstList[0].x - 25), 2) + Math.Pow((coordstList[0].y - 25), 2));
                double temp = distance;
                int x = 0;
                int y = 0;

                for (int i = 1; i < coordstList.Count; i++)
                {
                    distance = Math.Sqrt(Math.Pow((coordstList[i].x - 25), 2) + Math.Pow((coordstList[i].y - 25), 2));

                    if (distance > temp)
                    {
                        x = coordstList[i].x;
                        y = coordstList[i].y;
                    }
                }

                
                Console.WriteLine("The closest point's coordinate is: x = {0}, y = {1}", x, y);
            }
        }

        public enum Currency
        {
            Font,
            Dollar,
            Yuan,
            Forint
        }

        public struct Prize
        {
            public static double Amount;
            public static string Currency;
        }
    }
}
