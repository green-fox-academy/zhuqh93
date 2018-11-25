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
            CAB player = new CAB();

            player.FourDigits();

            foreach (var VARIABLE in player.DigitList)
            {
                Console.Write(VARIABLE);
            }

            Console.WriteLine();

            while (player.State == "playing")
            {
                Console.WriteLine("Please Enter Your Guess: \n" +
                                  "- Your guess should be a 4 digits number;\n" +
                                  "- Each digit should be unique;\n");

                Console.WriteLine(player.Guess(Console.ReadLine()));
                Console.WriteLine();

                if (player.State != "finished")
                {
                    Console.WriteLine("Try again: [y/n]\n");

                    string state = Console.ReadLine();

                    switch (state)
                    {
                        case "y":
                            player.State = "playing";
                            Console.WriteLine();
                            break;
                        case "n":
                            player.State = "finished";
                            Console.WriteLine("\nSee you again~");
                            break;
                        default:
                            Console.WriteLine("\nPlease answer with [y] or [n].");
                            Console.WriteLine();
                            break;
                    }

                    while ((state != "y") && (state != "n"))
                    {
                        Console.WriteLine("Try again: [y/n]\n");
                        state = Console.ReadLine();
                        switch (state)
                        {
                            case "y":
                                player.State = "playing";
                                Console.WriteLine();
                                break;
                            case "n":
                                player.State = "finished";
                                Console.WriteLine("\nSee you again~");
                                break;
                            default:
                                Console.WriteLine("\nPlease answer with [y] or [n].");
                                Console.WriteLine();
                                break;
                        }
                    }
                }
            }

            Console.Read();
        }
    }
}
