using System;
using System.Collections.Generic;
using System.Text;

namespace WorkshopTest
{
    public class Extension
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int MaxOfThree(int a, int b, int c)
        {
            int max = -1;

            if (a > b && a != b)
            {
                if (a > c && a != c)
                    max = a;
                else
                    max = c;
            }
            else if (a < b && a != b)
            {
                if (b > c && b != c)
                    max = b;
                else
                    max = c;
            }

            return max;
        }

        public int Median(List<int> pool)
        {
            pool.Sort();

            if (pool.Count % 2 == 0)
            {
                return (pool[(pool.Count - 1) / 2] + pool[pool.Count / 2]) / 2;
            }else
                return pool[pool.Count / 2];
        }

        public bool IsVowel(char c)
        {
            return (new List<char>() { 'a', 'u', 'o', 'e', 'i' }).Contains(c);
        }

        public string Translate(string hungarian)
        {
            string teve = "";
            List<string> teveList = new List<string>();
            
            for (int i = 0; i < hungarian.Length; i++)
            {
                char c = hungarian[i];

                if (IsVowel(c))
                {
                    teveList.Add(c + "v" + c);
                }
                else
                {
                    teveList.Add(c.ToString());
                }
            }

            foreach (var VARIABLE in teveList)
            {
                teve += VARIABLE;
            }

            //for (int i = 0; i < length; i++)
            //{
            //    char c = teve[i];
            //    if (IsVowel(c))
            //    {
            //        teve = string.Join(c + "v" + c, teve.Split(c));
            //        i += 2;
            //        length += 2;
            //    }
            //}

            return teve;
        }
    }
}
