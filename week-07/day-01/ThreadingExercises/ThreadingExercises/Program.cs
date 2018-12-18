using System;
using System.Threading;

namespace ThreadingExercises
{
    class Program
    {
        private static int[] intArray;
        private static int result;
        private static object syncObject = new object();

        static void Main(string[] args)
        {
            Console.WriteLine("Main thread: Start a second thread.");

            //try
            //{

            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("I got this!");
            //}

            intArray = GenerateRandomNumbers();

            Sum(intArray, 0, 1000000000);

            Thread t1 = new Thread(new ThreadStart(() => Sum(intArray, 0, 250000000)));
            Thread t2 = new Thread(new ThreadStart(() => Sum(intArray, 250000001, 250000000)));
            Thread t3 = new Thread(new ThreadStart(() => Sum(intArray, 500000001, 250000000)));
            Thread t4 = new Thread(new ThreadStart(() => Sum(intArray, 750000001, 250000000)));

            t1.Name = "Thread #1";
            t2.Name = "Thread #2";
            t3.Name = "Thread #3";
            t4.Name = "Thread #4";

            t1.Start();
            t2.Start();
            t3.Start();
            t4.Start();

            while (Console.ReadKey().KeyChar != 'q') ;
            Console.WriteLine();

            Console.WriteLine("Main thread: Call Join(), to wait until Sum ends.");
            t1.Join();
            t2.Join();
            t3.Join();
            t4.Join();

            Console.WriteLine($"Result value: {result}");
            Console.WriteLine("Main thread finished");
        }

        private static int[] GenerateRandomNumbers()
        {
            intArray = new int[1000000000];
            var r = new Random();

            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = r.Next(1, 5);
            }

            return intArray;
        }

        private static void Sum(int[] array, int from, int count)
        {
            result = 0;

            for (int i = from; i < count; i++)
            {
                lock (syncObject)
                {
                    result += array[i];
                }
            }

            Console.WriteLine($"{Thread.CurrentThread.Name} | result: {result}");
        }
    }
}
