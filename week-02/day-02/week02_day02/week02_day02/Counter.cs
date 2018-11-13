using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace week02_day02
{
    class Counter
    {
        private int value = 0;

        public Counter(int numberValue)
        {
            value = numberValue;
        }

        public void Add(int number)
        {
            value += number;
        }

        public void Add()
        {
            value++;
        }

        public string Get()
        {
            return value.ToString();
        }

        public void Reset()
        {
            value = 0;
        }
    }
}
