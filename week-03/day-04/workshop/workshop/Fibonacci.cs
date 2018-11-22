using System;
using System.Collections.Generic;
using System.Text;

namespace WorkshopTest
{
    public class Fibonacci
    {
        public int generateFibonacci(int index)
        {
            int fibonacciNum = 0;
            List<int> fibonacciList = new List<int>{0, 1};

            if (index == 1)
            {
                fibonacciNum = fibonacciList[0];
            }else if (index == 2)
            {
                fibonacciNum = fibonacciList[1];
            }
            else if (index > 2)
            {
                for (int i = 2; i < index; i++)
                {
                    fibonacciList.Add(0);
                    fibonacciList[i] = fibonacciList[i - 1] + fibonacciList[i - 2];
                }

                fibonacciNum = fibonacciList[index - 1];
            }

            return fibonacciNum;
        }
    }
}
