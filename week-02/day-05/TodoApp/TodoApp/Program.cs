using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
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

            Print();

            while (!userInput.Equals("-e"))
            {
                string @operator = "";
                string content = "";

                Console.WriteLine("Please enter your command: ");
                userInput = Console.ReadLine().Trim();
                Console.WriteLine();

                if (!string.IsNullOrWhiteSpace(userInput))
                {
                    if (userInput.Length > 2)
                    {
                        @operator = userInput.Substring(0, 2).Trim();
                        content = userInput.Substring(2, userInput.Length - 2).Trim();
                    }
                    else
                        @operator = userInput;
                }
                else if (string.IsNullOrWhiteSpace(userInput))
                {
                    Console.WriteLine("Null argument, type '-h' for help.");
                    @operator = "";
                }
                
                if (@operator == "-l")
                {
                    if (!string.IsNullOrWhiteSpace(content)) Console.WriteLine("Wrong Listing syntax - but I'll list for you anyway :)\n");

                    List(path);
                }
                else if (@operator == "-a")
                {
                    try
                    {
                        if (string.IsNullOrWhiteSpace(content)) throw new Exception();
                        else
                        {
                            content = content.Substring(1, content.Length - 2);
                        }

                        AddNew(content, path);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Unable to add: no task provided");
                    }
                }
                else if (@operator == "-r")
                {
                    try
                    {
                        isNumeric = int.TryParse(content, out int n);

                        if (string.IsNullOrWhiteSpace(content))
                        {
                            Console.WriteLine("Unable to remove: no index provided");
                            throw new Exception();
                        }
                        else if (!isNumeric)
                        {
                            Console.WriteLine("Unable to remove: index is not a number");
                            throw new Exception();
                        }
                        else if (int.Parse(content) > File.ReadAllLines(path).ToList().Count)
                        {
                            Console.WriteLine("Unable to remove: index is out of bound");
                            throw new Exception();
                        }
                        else if (isNumeric)
                        {
                            int index = int.Parse(content) - 1;
                            Remove(index, path);
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Sorry, please try again.");
                    }
                }
                else if (@operator == "-c")
                {
                    try
                    {
                        isNumeric = int.TryParse(content, out int n);

                        if (string.IsNullOrWhiteSpace(content))
                        {
                            Console.WriteLine("Unable to check: no index provided");
                            throw new Exception();
                        }
                        else if (!isNumeric)
                        {
                            Console.WriteLine("Unable to check: index is not a number");
                            throw new Exception();
                        }
                        else if (int.Parse(content) > File.ReadAllLines(path).ToList().Count)
                        {
                            Console.WriteLine("Unable to check: index is out of bound");
                            throw new Exception();
                        }
                        else if (isNumeric)
                        {
                            int index = int.Parse(content) - 1;
                            Check(index, path);
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Sorry, please try again.");
                    }
                }
                else if (@operator == "-h") PrintLite();
                else if (@operator == "-e") break;
                else if (@operator == "") { }
                else Console.WriteLine("Unsupported argument");

                Console.WriteLine();
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
                              " -c   Completes an task\n" +
                              " -e   Exit the application\n" +
                              " -h   Get help\n");
        }

        static void PrintLite()
        {
            Console.WriteLine("Command line arguments:\n" +
                              " -l   Lists all the tasks\n" +
                              " -a   Adds a new task\n" +
                              " -r   Removes an task\n" +
                              " -c   Completes an task\n" +
                              " -e   Exit the application\n" +
                              " -h   Get help");
        }

        static void List(string path)
        {
            if (!File.Exists(path))
                using (File.Create(path)) { }

            List<string> todoList = File.ReadAllLines(path).ToList();

            if (todoList.Count != 0)
                for (int i = 0; i < todoList.Count; i++) Console.WriteLine($"{i + 1} - {todoList[i]}");
            else
                Console.WriteLine("No todos for today! :)");
        }

        static void AddNew(string content, string path)
        {
            if (!File.Exists(path))
                using (File.Create(path)) { }

            using (StreamWriter writer = File.AppendText(path)) writer.WriteLine($"[ ] {content}");
        }

        static void AddExist(string content, string path)
        {
            if (!File.Exists(path))
                using (File.Create(path)) { }

            using (StreamWriter writer = File.AppendText(path)) writer.WriteLine(content);
        }

        static void Remove(int index, string path)
        {
            List<string> todoList = File.ReadAllLines(path).ToList();

            todoList.RemoveAt(index);

            File.Delete(path);

            foreach (var task in todoList) AddExist(task, path);
        }

        static void Check(int index, string path)
        {
            List<string> todoList = File.ReadAllLines(path).ToList();

            var todo = todoList[index];
            todo = "[x" + todo.Substring(2, todo.Length - 2);
            todoList[index] = todo;

            File.Delete(path);

            foreach (var t in todoList) AddExist(t, path);
        }
    }
}
