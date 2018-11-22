using System;
using System.Collections.Generic;
using System.Text;

namespace WorkshopTest
{
    public class CountLetters
    {
        public Dictionary<char, int> CountLetter(string aString)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();

            char[] charArray = aString.ToCharArray();

            foreach (var VARIABLE in charArray)
            {
                if (dict.ContainsKey(VARIABLE))
                {
                    dict[VARIABLE]++;
                }
                else
                {
                    dict.Add(VARIABLE, 1);
                }
            }

            return dict;
        }
    }
}
