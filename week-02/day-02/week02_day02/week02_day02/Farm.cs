using System;
using System.Collections.Generic;
using System.Text;

namespace week02_day02
{
    class Farm
    {
        private List<Animal> listOfAnimals;
        private int slots;

        public Farm()
        {
            listOfAnimals = new List<Animal>();
            slots = 0;
        }

        public void Slaughter()
        {
            int temp = listOfAnimals[0].GetHunger();
            int index = 0;

            for (int i = 0; i < listOfAnimals.Count; i++)
            { 
                if (listOfAnimals[i].GetHunger() < temp)
                {
                    temp = listOfAnimals[i].GetHunger();
                    index = i;
                }
            }

            listOfAnimals.RemoveAt(index);
            slots++;
        }

        public void Breed()
        {
            if (slots > 0)
            {
                Animal animal = new Animal();
                listOfAnimals.Add(animal);
                slots--;
            }
            else
            {
                Console.WriteLine("There's no place currently.");
            }
        }
    }
}
