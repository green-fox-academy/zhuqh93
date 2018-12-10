using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frontend.Services
{
    public class FrontendServices : IFrontendServices
    {
        public int Sum(int until)
        {
            var result = 0;

            for (int i = 1; i <= until; i++) result += i;

            return result;
        }

        public int Factor(int until)
        {
            var result = 1;

            for (int i = 1; i <= until; i++) result *= i;

            return result;
        }

        public int Sum(int[] intArray)
        {
            var result = 0;

            foreach (var integer in intArray) result += integer;

            return result;
        }

        public int Multiply(int[] intArray)
        {
            var result = 1;

            foreach (var integer in intArray) result *= integer;

            return result;
        }

        public int[] Double(int[] intArray)
        {
            int[] result = new int[intArray.Length];

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = intArray[i] * 2;
            }

            return result;
        }
    }
}
