using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace The_Garden_Application
{
    class Garden
    {
        internal List<Flower> FlowerList = new List<Flower>();
        internal List<Tree> TreeList = new List<Tree>();
        
        public void WaterGarden40()
        {
            foreach (var flower in FlowerList)
            {
                if (flower.IfNeedWater())
                {
                    flower.flowerWaterAmount += 40 / NumberOfPlantsNeedWater() * Flower.FLOWER_ABSORB_RATE;
                }
            }

            foreach (var tree in TreeList)
            {
                if (tree.IfNeedWater())
                {
                    tree.treeWaterAmount += 40 / NumberOfPlantsNeedWater() * Tree.TREE_ABSORB_RATE;
                }
            }
        }

        public void WaterGarden70()
        {
            foreach (var flower in FlowerList)
            {
                if (flower.IfNeedWater())
                {
                    flower.flowerWaterAmount += 70 / NumberOfPlantsNeedWater() * Flower.FLOWER_ABSORB_RATE;
                }
            }

            foreach (var tree in TreeList)
            {
                if (tree.IfNeedWater())
                {
                    tree.treeWaterAmount += 70 / NumberOfPlantsNeedWater() * Tree.TREE_ABSORB_RATE;
                }
            }
        }

        public void GardenStatus()
        {
            foreach (var flower in FlowerList)
            {
                if (flower.IfNeedWater())
                {
                    Console.WriteLine("The {0} Flower needs water", flower.flowerColor);
                }
                else if (!flower.IfNeedWater())
                {
                    Console.WriteLine("The {0} Flower doesnt need water", flower.flowerColor);
                }
            }

            foreach (var tree in TreeList)
            {
                if (tree.IfNeedWater())
                {
                    Console.WriteLine("The {0} Tree needs water", tree.treeColor);
                }
                else if (!tree.IfNeedWater())
                {
                    Console.WriteLine("The {0} Tree doesnt need water", tree.treeColor);
                }
            }
        }

        public double NumberOfPlantsNeedWater()
        {
            double count = 0;

            foreach (var flower in FlowerList)
            {
                if (flower.IfNeedWater())
                {
                    count++;
                }
            }

            foreach (var tree in TreeList)
            {
                if (tree.IfNeedWater())
                {
                    count++;
                }
            }

            return count;
        }
    }
}
