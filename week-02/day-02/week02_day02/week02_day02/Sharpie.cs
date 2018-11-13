using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace week02_day02
{
    class Sharpie
    {
        private string Color = "";
        private float Width = 0;
        private float InkAmount = 0;

        public Sharpie(string color, float width)
        {
            Color = color;
            Width = width;
            InkAmount = 100;
        }

        public void Use()
        {
            InkAmount--;
        }

        public float GetInkAmount()
        {
            return InkAmount;
        }
    }
}
