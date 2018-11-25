using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace workshop
{
    public class CAB
    {
        public string State { get; set; }
        public List<int> Counter { get; private set; }
        public List<int> DigitList { get; private set; }

        public CAB()
        {
            State = "playing";
            Counter = new List<int> {0, 0};
        }

        public void FourDigits()
        {   
            DigitList = new List<int>();
            Random rnd = new Random();

            while (DigitList.Count < 4)
            {
                int newRandom = rnd.Next(0, 10);

                if (!DigitList.Contains(newRandom))
                {
                    DigitList.Add(newRandom);
                }
            }
        }

        public string Guess(string guess)
        {
            List<int> guessList = new List<int> ();
            for (int i = 0; i < guess.Length; i++)
            {
                // convert char to int:
                // for example - '9' in ASCII is 57, '0' in ASCII is 48, so ('9' - '0') = (57 - 48) = int 9.
                guessList.Add(guess[i] - '0');
            }

            int cows = 0;
            int bulls = 0;

            for (int i = 0; i < DigitList.Count; i++)
            {
                if (DigitList[i] == guessList[i])
                {
                    cows++;
                }
                else 
                {
                    foreach (var VARIABLE in guessList)
                    {
                        if (DigitList[i] == VARIABLE)
                        {
                            bulls++;
                        }
                    }
                }
            }

            Counter[0] = cows;
            Counter[1] = bulls;

            if (cows == 4)
            {
                Console.WriteLine("\nWooooW You Won!");
                this.State = "finished";
            }

            return $"\n{cows} Cows, {bulls} Bulls.";
        }
    }
}
