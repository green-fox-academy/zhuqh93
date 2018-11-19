using System;
using System.Collections;
using System.Collections.Generic;

namespace workshop
{
    class Program
    {
        static void Main(string[] args)
        {
//            CloneAble();
//            Comparable();
        }

        private static void CloneAble()
        {
            Student john = new Student("John", 20, "male", "BME");
            Student johnTheClone = john.Clone() as Student;
            johnTheClone.Introduce();
        }

        public static void Comparable()
        {
            ArrayList dominoes = new ArrayList();
            dominoes.Add(new Domino(5, 2));
            dominoes.Add(new Domino(4, 6));
            dominoes.Add(new Domino(1, 5));
            dominoes.Add(new Domino(6, 7));
            dominoes.Add(new Domino(2, 4));
            dominoes.Add(new Domino(7, 1));

            dominoes.Sort();

            List<string> dominoStringList = new List<string>();

            foreach (Domino element in dominoes)
            {
                int[] domino = element.GetValues();
                dominoStringList.Add("[" + domino[0] + "," + domino[1] + "]");
            }

            string result = string.Join(", ", dominoStringList);
            
            Console.WriteLine("[" + result + "]");
        }
    }
}
