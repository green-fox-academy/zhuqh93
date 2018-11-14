using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

namespace week02_day03
{
    class Program
    {
        static void Main(string[] args)
        {
//            DivideByZero();

//            PrintEachLine();

//            CountLine();

//            WriteSingleLine();

//            WriteMultipleLines(@"C:\Users\Jimmy_Zhu\Projects\dotnet-academy\greenfox\zhuqh93\week-02\day-03\week02_day03\week02_day03\my-file.txt", "Apple", 5);

            //Console.WriteLine(CopyFile("my-file.txt", "copy-my-file.txt"));


        }

        private static void DivideByZero()
        {
            try // Prevents the program breaking when attempting dividing by zero
            {
                Console.WriteLine("Enter a number as divisor:");
                int divisor = int.Parse(Console.ReadLine());
                // If the input value for divisor was 0 the program breaks
                int result = 10 / divisor;
                // The program doesn't reach this line if the input was 0
                Console.WriteLine("Result is: {0}", result);
            }
            catch (DivideByZeroException e)
            {
                // This line only runs if the input was 0
                Console.WriteLine("fail");
            }
            catch (Exception e)
            {
                // This line only runs if uncatched exception generated
                Console.WriteLine("uuups, some serious thing happened!");
            }
            finally
            {
                Console.ReadLine();
            }
        }

        private static void PrintEachLine()
        {
            try
            {
                String[] contentArray = File.ReadAllLines("my-file.txt");
                foreach (var line in contentArray)
                {
                    Console.WriteLine(line);
                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("Unable to read file: my-file.txt");
            }
            finally
            {
                Console.ReadLine();
            }
        }

        private static void CountLine()
        {
            try
            {
                String fileName = "my-file.txt";
                int count = 0;
                String[] contentArray = File.ReadAllLines(fileName);

                foreach (var element in contentArray)
                {
                    count++;
                }

                Console.WriteLine("Number of lines: {0}", count);
            }
            catch (Exception e)
            {
                Console.WriteLine("0");
            }
            finally
            {
                Console.ReadLine();
            }
        }

        private static void WriteSingleLine()
        {
            try
            {
                String path =
                    @"C:\Users\Jimmy_Zhu\Projects\dotnet-academy\greenfox\zhuqh93\week-02\day-03\week02_day03\week02_day03\my-file.txt";

                using (StreamWriter writer = new StreamWriter(path))
                {
                    writer.WriteLine("Jimmy Zhu");
                }

                using (StreamReader reader = new StreamReader(path))
                {
                    Console.WriteLine(reader.ReadLine());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Unable to write file: my-file.txt");
            }
            finally
            {
                Console.ReadLine();
            }
        }

        private static void WriteMultipleLines(String path, String word, int number)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(path))
                {
                    for (int i = 0; i < number; i++)
                    {
                        writer.WriteLine(word);
                    }
                }
            }
            catch (Exception e)
            {
                
            }
            finally
            {
                Console.ReadLine();
            }
        }

        private static bool CopyFile(String originalFile, String copyOfOriginal)
        {
            Boolean result = false;

            try
            {
                String tempCopy = "";
                List<String> contentList = new List<string>();
                StreamReader originalReader = new StreamReader(originalFile);

                while (tempCopy != null)
                {
                    tempCopy = originalReader.ReadLine();
                    contentList.Add(tempCopy);
                }

                originalReader.Close();

                StreamWriter writer = new StreamWriter(copyOfOriginal);

                foreach (var content in contentList)
                {
                    writer.WriteLine(content);
                }

                writer.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return true;
            Console.ReadLine();
        }
    }
}
