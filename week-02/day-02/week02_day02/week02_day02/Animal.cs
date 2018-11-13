using System;
using System.Collections.Generic;
using System.Text;

namespace week02_day02
{
    class Animal
    {
        private int hunger = 0;
        private int thirst = 0;

        public Animal()
        {
            hunger = 50;
            thirst = 50;
        }

        public void eat()
        {
            hunger--;
        }

        public void drink()
        {
            thirst--;
        }

        public void play()
        {
            hunger++;
            thirst++;
        }

        public int GetHunger()
        {
            return hunger;
        }
    }
}
