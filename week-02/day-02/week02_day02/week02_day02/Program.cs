using System;
using System.Collections.Generic;

namespace week02_day02
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                        List<Pokemon> pokemonOfAsh = InitializePokemon();
                        Pokemon wildPokemon = new Pokemon("Oddish", "leaf", "water");
                        Console.Write("I choose you, {0}", wildPokemon.counterPokemonIs(pokemonOfAsh));
            */

            /*
                        var fleet = new Fleet();
                        Thing task1 = new Thing("Get milk");
                        Thing task2 = new Thing("Remove the obstacles");
                        Thing task3 = new Thing("Stand up");
                        Thing task4 = new Thing("Eat lunch");
                        fleet.Add(task1);
                        fleet.Add(task2);
                        fleet.Add(task3);
                        fleet.Add(task4);
                        task3.Complete();
                        task4.Complete();
                        Print(fleet);
            */

            /*
            RollSix();
*/



            Console.ReadLine();
        }

        private static List<Pokemon> InitializePokemon()
        {
            return new List<Pokemon>
            {
                new Pokemon("Balbasaur", "leaf", "water"),
                new Pokemon("Pikatchu", "electric", "water"),
                new Pokemon("Charizard", "fire", "leaf"),
                new Pokemon("Balbasaur", "water", "fire"),
                new Pokemon("Kingler", "water", "fire")
            };
        }

        private static void Print(Fleet fleet)
        {
            for (int i = 0; i < fleet.GetThings().Count; i++)
            {
                if (fleet.GetThings()[i].IsCompleted())
                {
                    Console.WriteLine("{0}. [x] {1}", i + 1, fleet.GetThings()[i].GetName());
                }
                else
                {
                    Console.WriteLine("{0}. [ ] {1}", i + 1, fleet.GetThings()[i].GetName());
                }
            }
        }

        private static void RollSix()
        {
            DiceSet diceSet = new DiceSet();
            diceSet.Reroll(); 
            for (int i = 0; i < diceSet.GetCurrent().Length; i++)
            {
                while (diceSet.GetCurrent(i) != 6)
                {
                    diceSet.Reroll(i);
                }
            }

            Console.WriteLine("[{0}]", String.Join(", ", diceSet.GetCurrent()));
        }
    }
}
