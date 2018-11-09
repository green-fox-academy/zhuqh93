using System;

namespace Lecture_day_05
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             int[] intArray = {1, 2, 3, 4};
            int[] intArray2 = new int[4];

            foreach (var number in intArray)
            {
                Console.WriteLine("Iterating with foreach: {0}", number);
            }

            for (int i = 0; i < intArray.Length; i++)
            {
                Console.WriteLine("Iterating with for: {0}", intArray[i]);
            }

            int[,] matrix = new int[3,3];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.WriteLine(matrix[i,j]);
                }
            }

            int[][] matrixTwo = {new[] {1, 2, 3}, new[] {1, 2}};

            for (int i = 0; i < matrixTwo.Length; i++)
            {
                for (int j = 0; j < matrixTwo[i].Length; j++)
                {
                    Console.WriteLine(matrixTwo[i][j]);
                }
            }
            */

            Addition(1,2,3,4,5,6);
            Addition(1, 2);
            MakeItDouble();
            MakeItDouble(3);

            int i = 3;
            ChangeIt(ref i);
            Console.WriteLine(i);
            //output = 5; without ref, output = 3;

            int[] intArray = {1};
            ChangeIt(intArray);
            Console.WriteLine(intArray[0]);
            //output = 4; coz intArray is an array type, which is not a value type, instead it is a reference type.
        }

        static int Addition(params int[] intArray)
        {
            int sum = 0;
            foreach (var number in intArray)
            {
                sum += number;
            }

            return sum;
        }

        static int MakeItDouble(int a = 5)
        //could accept empty parameter and fill will default value, in this case is 5;
        {
            return a * 2;
        }

        static void ChangeIt(ref int number)
        {
            number = 5;
        }

        static void ChangeIt(int[] array)
        {
            array[0] = 4;
        }
    }
}
