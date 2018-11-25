using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace workshop
{
    public class Sharpie
    {
        public string Color { get; }
        public float Width { get; }
        public float InkAmount { get; private set; }

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
