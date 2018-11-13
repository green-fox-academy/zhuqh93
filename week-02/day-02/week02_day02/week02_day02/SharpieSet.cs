using System;
using System.Collections.Generic;
using System.Text;

namespace week02_day02
{
    class SharpieSet
    {
        private List<Sharpie> sharpieSet;

        public SharpieSet()
        {
            sharpieSet = new List<Sharpie>();
        }

        public int CountUsable()
        {
            int counter = 0;

            foreach (var sharpie in sharpieSet)
            {
                if (sharpie.GetInkAmount() == 0)
                {
                    counter++;
                }
            }

            return counter;
        }

        public void RemoveTrash()
        {
            for (int i = 0; i < sharpieSet.Count; i++)
            {
                if (sharpieSet[i].GetInkAmount() == 100)
                {
                    sharpieSet.RemoveAt(i);
                }
            }
        }
    }
}
