using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace week02_day02
{
    class Station
    {
        private static int gasAmount;

        public static void Refill(Car car)
        {
            gasAmount -= car.GetCapacity();
            car.SetGasAmount(car.GetCapacity());
        }
    }
}
