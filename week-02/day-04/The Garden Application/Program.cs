using System;

namespace The_Garden_Application
{
    class Program
    {
        static void Main(string[] args)
        {
            GardenDemo();

            Console.ReadLine();
        }

        static void GardenDemo()
        {
            Garden newGarden = new Garden();

            Flower flower1 = new Flower("yellow", 0);
            Flower flower2 = new Flower("blue", 0);
            Tree tree1 = new Tree("purple", 0);
            Tree tree2 = new Tree("orange", 0);

            newGarden.FlowerList.Add(flower1);
            newGarden.FlowerList.Add(flower2);
            newGarden.TreeList.Add(tree1);
            newGarden.TreeList.Add(tree2);

            newGarden.GardenStatus();

            Console.WriteLine();

            if (newGarden.NumberOfPlantsNeedWater() > 0)
            {
                newGarden.WaterGarden40();
                Console.WriteLine("Watering with 40");
                newGarden.GardenStatus();
            }

            Console.WriteLine();

            if (newGarden.NumberOfPlantsNeedWater() > 0)
            {
                newGarden.WaterGarden70();
                Console.WriteLine("Watering with 70");
                newGarden.GardenStatus();
            }
        }
    }
}
