using System;
using System.Collections.Generic;
using System.Text;

namespace workshop
{
    public class Sum
    {
        public int SumInt(List<int> intList)
        {
            int result = 0;

            foreach (var integer in intList)
            {
                result += integer;
            }

            return result;
        }
    }
}
