using System;
using System.Collections.Generic;
using System.Text;

namespace The_Garden_Application
{
    class Tree
    {
        internal string treeColor{ get; set; }
        internal double treeWaterAmount { get; set; }
        internal const double TREE_ABSORB_RATE = 0.4;

        public Tree(string color, double waterAmount)
        {
            this.treeColor = color;
            this.treeWaterAmount = waterAmount;
        }

        public bool IfNeedWater()
        {
            bool result = false;

            if (treeWaterAmount > 0 && treeWaterAmount < 10)
            {
                result = true;
            }
            else if (treeWaterAmount >= 10)
            {
                result = false;
            }

            return result;
        }
    }
}
