using System;
using System.Collections.Generic;
using System.Text;

namespace WorkshopTest
{
    public class Anagram
    {
        public bool IsAnagramms(string subject, string _object)
        {
            bool result = false;

            // cut whitespace and convert to lowercase
            string formatedSubject = subject.Replace(" ", "").ToLower();
            string formatedObject = _object.Replace(" ", "").ToLower();

            // sort as char array
            char[] subCharArray = formatedSubject.ToCharArray();
            Array.Sort(subCharArray);
            char[] objCharArray = formatedObject.ToCharArray();
            Array.Sort(objCharArray);

            // convert back into string
            string finalSubject = "";
            string finalObject = "";

            foreach (var VARIABLE in subCharArray)
            {
                finalSubject += VARIABLE;
            }

            foreach (var VARIABLE in objCharArray)
            {
                finalObject += VARIABLE;
            }

            if (finalSubject.Length != finalObject.Length)
            {
                result = false;
            }

            if (finalSubject.Equals(finalObject))
            {
                result = true;
            }
            
            return result;
        }
    }
}
