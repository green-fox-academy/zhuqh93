using System;
using System.Collections.Generic;
using System.Text;

namespace week02_day02
{
    class Car
    {
        private int gasAmount = 0;
        private int capacity = 0;

        public Car()
        {
            this.gasAmount = 0;
            this.capacity = 100;
        }

        public void SetGasAmount(int gasAmount)
        {
            this.gasAmount = gasAmount;
        }

        public int GetCapacity()
        {
            return capacity;
        }
    }
}
