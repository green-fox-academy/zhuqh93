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
            int result = 0;

            for (int i = 1; i <= until; i++)
            {
                result += i;
            }

            return result;
        }

        public int Factor(int until)
        {
            int result = 0;

            for (int i = 1; i <= until; i++)
            {
                result *= i;
            }

            return result;
        }
    }
}
