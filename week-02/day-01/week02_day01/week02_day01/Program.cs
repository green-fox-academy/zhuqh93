using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace week02_day01
{
    class Program
    {
        static void Main(string[] args)
        {
            //            SimpleReplace();

            //            UrlFixer();

            //            TakesLonger();

            //            TodoPrint();

            //            string reversed = ".eslaf eb t'ndluow ecnetnes siht ,dehctiws erew eslaf dna eurt fo sgninaem eht fI";
            //            Console.WriteLine(Reverse(reversed));

            //            var planetList = new List<string> { "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Uranus", "Neptune" };
            //            Console.WriteLine(PutSaturn(planetList));

            //            var girls = new List<string> { "Eve", "Ashley", "Claire", "Kat", "Jane" };
            //            var boys = new List<string> { "Joe", "Fred", "Tom", "Todd", "Neef", "Jeff" };
            //            Console.WriteLine(MakingMatches(girls, boys));

            //            var far = new List<string> { "bo", "anacond", "koal", "pand", "zebr" };
            //            Console.WriteLine(AppendA(far));

            //            var list = new List<object>();
            //            list.Add("Cupcake");
            //            list.Add(2);
            //            list.Add("Brownie");
            //            list.Add(false);
            //            Console.WriteLine(Sweets(list));

            //            var List = new List<int> { 1, 2, 3, 4, 5 };
            //            Console.WriteLine(ContainsSeven(List));

            //            var list = new List<int> { 2, 4, 6, 8, 10, 12, 14, 16 };
            //            Console.WriteLine(CheckNums(list));

            var list = new List<string> { "What", "I", "do", "create,", "I", "cannot", "not", "understand." };
            Console.WriteLine(QuoteSwap(list));

            Console.ReadLine();
        }

        static void SimpleReplace()
        {
            string example = "In a dishwasher far far away";

            example.Replace("dishwasher", "galaxy");

            Console.WriteLine(example);
        }

        static void UrlFixer()
        {
            string url = "https//www.reddit.com/r/nevertellmethebots";

            // Accidentally I got the wrong URL for a funny subreddit. It's probably "odds" and not "bots"
            // Also, the URL is missing a crucial component, find out what it is and insert it too!
            // Try to solve it more than once using different string functions!
            
//            url = url.Insert(5, ":");
//            url = url.Replace("bots", "odds");

//            url = "https://www.reddit.com/r/nevertellmetheodds";

            url = url.Remove(5) + "://www.reddit.com/r/nevertellmetheodds";
            Console.WriteLine(url);
        }

        static void TakesLonger()
        {
            string quote = "Hofstadter's Law: It you expect, even when you take into account Hofstadter's Law.";

            // When saving this quote a disk error has occured. Please fix it.
            // Add "always takes longer than" to the StringBuilder (quote) between the words "It" and "you"
            // Using pieces of the quote variable (instead of just redefining the string)
            string[] quoteArray = "always takes longer than".Split(" ");
            StringBuilder quoteStringBuilder = new StringBuilder();
            quoteStringBuilder.Append(quote);
            for(int i =1; i <= quoteArray.Length; i++)
            {
                quoteStringBuilder.Insert(21, quoteArray[quoteArray.Length - i] + " ");
            }
            
            Console.WriteLine(quoteStringBuilder);
        }

        static void TodoPrint()
        {
            string todoText = " - Buy milk\n";
            // Add "My todo:" to the beginning of the todoText
            // Add " - Download games" to the end of the todoText
            // Add " - Diablo" to the end of the todoText but with indentation

            // Expected output:

            // My todo:
            //  - Buy milk
            //  - Download games
            //      - Diablo
            StringBuilder newTodoText = new StringBuilder();
            newTodoText.Append(todoText);
            newTodoText.Insert(0, "My todo:\n");
            newTodoText.Append(" - Download games\n");
            newTodoText.Append("     - Diablo");
            Console.WriteLine(newTodoText);
        }

        static string Reverse(string reverseString)
        {
            // Create a method that can reverse a String, which is passed as the parameter
            // Use it on this reversed string to check it
            StringBuilder reversedStringBuilder = new StringBuilder();

            foreach (var character in reverseString)
            {
                reversedStringBuilder.Insert(0, character);
            }

            return reversedStringBuilder.ToString();
        }

        static string PutSaturn(List<string> planetList)
        {
            for(int i = 0; i < planetList.Count; i++)
            {
                if (planetList[i] == "Jupiter")
                {
                    planetList.Insert(i + 1, "Saturn");
                }
            }
            return "\"" + string.Join("\", \"", planetList.ToArray()) + "\"";
        }

        static string MakingMatches(List<string> girls, List<string> boys)
        {
            List<string> newList = new List<string>();
            
            for(int i = 0; i < girls.Count; i++)
            {
                newList.Add(girls[i]);
                newList.Add(boys[i]);
            }

            return "\"" + string.Join("\", \"", newList.ToArray()) + "\"";
        }

        static string AppendA(List<string>stringList)
        {
            StringBuilder newStringBuilder = new StringBuilder();
            foreach (var element in stringList)
            {
                if (!element.Equals("zebr"))
                {
                    newStringBuilder.Append("\"" + element + "a\", ");
                }
                else
                {
                    newStringBuilder.Append("\"" + element + "a\"");
                }
            }

            return newStringBuilder.ToString();
        }

        static string Sweets(List<object> aList)
        {
            for (int i = 0; i < aList.Count; i++)
            {
                if (aList[i].Equals(2))
                {
                    aList.RemoveAt(i);
                    aList.Insert(i, "Croissant");
                }else if (aList[i].Equals(false))
                {
                    aList.RemoveAt(i);
                    aList.Insert(i, "Ice cream");
                }
            }
            return "\"" + string.Join("\", \"", aList.ToArray()) + "\"";
        }

        static string ContainsSeven(List<int> intList)
        {
            string result = "";

            /*foreach (var number in intList)
            {
                if (number == 7)
                {
                    result = "Hoorray";
                }
                else
                {
                    result = "Noooooo";
                }
            }*/

            foreach (var number in intList)
            {
                if (intList.Contains(7))
                {
                    result = "Hoorray";
                }
                else
                {
                    result = "Noooooo";
                }
            }
            return result;
        }

        static Boolean CheckNums(List<int> intList)
        {
            Boolean result = false;

            if (intList.Contains(4) && intList.Contains(8) && intList.Contains(12) && intList.Contains(16))
            {
                result = true;
            }

            return result;
        }

        static string QuoteSwap(List<string> stringList)
        {
            string tempString = "";
            int index1 = stringList.IndexOf("do");
            int index2 = stringList.IndexOf("cannot");
            tempString = stringList[index1];
            stringList[index1] = stringList[index2];
            stringList[index2] = tempString;

            return "\"" + string.Join(" ", stringList) + "\"";
        }

        static void Calculate()
        {

        }
    }
}
