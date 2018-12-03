using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace TodoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"./data.txt";
            string userInput = "";
            bool isNumeric;

            while (!userInput.Equals("exit"))
            {
                Console.WriteLine();
                userInput = Console.ReadLine();
                Console.WriteLine();

                if (userInput != null && userInput.Equals(""))
                {
                    Print();
                }
                else if (userInput.Equals("-l"))
                {
                    List(path);
                }
                else if (userInput.Substring(0,2).Equals("-a"))
                {
                    try
                    {
                        if (userInput.Trim().Equals("-a"))
                        {
                            throw new Exception();
                        }

                        Add(userInput.Substring(4, userInput.Length - 5), path);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Unable to add: no task provided");
                    }

                }else if (userInput.Substring(0,2).Equals("-r"))
                {
                    try
                    {
                        isNumeric = int.TryParse(userInput.Trim().Substring(2), out int n);

                        if (userInput.Trim().Equals("-r"))
                        {
                            Console.WriteLine("Unable to remove: no index provided");
                            throw new Exception();
                        }
                        else if (int.Parse(userInput.Trim().Substring(3)) > userInput.Length-1)
                        {
                            Console.WriteLine("Unable to remove: index is out of bound");
                            throw new Exception();
                        }
                        else if (!isNumeric)
                        {
                            Console.WriteLine("Unable to remove: index is not a number");
                            throw new Exception();
                        }

                        int index = int.Parse(userInput.Trim().Substring(3)) - 1;
                        Remove(index, path);
                    }
                    catch (Exception)
                    {
                        // ignored
                    }
                }
                else if (userInput.Substring(0, 2).Equals("-c"))
                {
                    int index = int.Parse(userInput.Trim().Substring(3)) - 1;
                    Check(index, path);
                }
                else
                {
                    Console.WriteLine("Unsupported argument");
                    Console.WriteLine();
                    Print();
                }
            }
            
        }

        static void Print()
        {
            Console.WriteLine("Command Line Todo application\n" +
                              "=============================\n\n" +
                              "Command line arguments:\n" +
                              " -l   Lists all the tasks\n" +
                              " -a   Adds a new task\n" +
                              " -r   Removes an task\n" +
                              " -c   Completes an task\n");
        }

        static void List(string path)
        {
            if (!File.Exists(path))
            {
                using (File.Create(path))
                {
                }
            }

            List<string> taskList = File.ReadAllLines(path).ToList();
            
            if (taskList.Count != 0)
            {
                for (int i = 0; i < taskList.Count; i++)
                {
                    Console.WriteLine($"{i + 1} - {taskList[i]}");
                }
            }
            else
            {
                Console.WriteLine("No todos for today! :)");
            }
        }

        static void Add(string content, string path)
        {
            using (StreamWriter writer = File.AppendText(path))
            {
                writer.WriteLine("[ ] " + content);
            }
        }

        static void Remove(int index, string path)
        {
            List<string> taskList = File.ReadAllLines(path).ToList();
            taskList.RemoveAt(index);
            File.Delete(path);
            
            foreach (var task in taskList)
            {
                Add(task, path);
            }
        }

        static void Check(int index, string path)
        {
            List<string> taskList = File.ReadAllLines(path).ToList();
            File.Delete(path);

            for (int i = 0; i < taskList.Count; i++)
            {
                if (i == index)
                {
                    taskList[i] = "[x] " + taskList[i];
                    Add(taskList[i], path);
                }
                else
                {
                    taskList[i] = "[ ] " + taskList[i];
                    Add(taskList[i], path);
                }
            }
        }
    }
}
