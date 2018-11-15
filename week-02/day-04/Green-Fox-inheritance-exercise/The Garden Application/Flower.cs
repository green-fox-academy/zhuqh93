using System;
using System.Collections.Generic;
using System.Text;

namespace The_Garden_Application
{
    class Flower
    {
        internal string flowerColor { get; set; }
        internal double flowerWaterAmount { get; set; }
        internal const double FLOWER_ABSORB_RATE = 0.75;

        public Flower(string color, double waterAmount)
        {
            this.flowerColor = color;
            this.flowerWaterAmount = waterAmount;
        }

        public bool IfNeedWater()
        {
            bool result = false;

            if (flowerWaterAmount > 0 && flowerWaterAmount < 5)
            {
                result = true;
            }
            else if (flowerWaterAmount >= 5)
            {
                result = false;
            }
            
            return result;
        }
    }
}
