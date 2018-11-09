using System;
using System.Threading;

namespace Workshop_day_4
{
    class Program
    {
        static void Main(string[] args)
        {
//            Exercise_01(); //HelloMe

//            Exercise_02(); //HumptyDumpty

//            Exercise_03(); //HelloOthers

//            Exercise_04(); //IntroduceYourself

//            Exercise_05(); //TwoNumbers

//            Exercise_06(); //CodingHours

//            Exercise_07(); //FavoriteNumber

//            Exercise_08();
//
//            Exercise_09();
//
//            Exercise_10();
//
//            Exercise_11();
//
//            Exercise_12();
//
//            Exercise_13();
//
//            Exercise_14();
//
//            Exercise_15();
//
//            Exercise_16();
//
//            Exercise_17();
//
//            Exercise_18();
//
//            Exercise_19();
//
//            Exercise_20();
//
//            Exercise_21();
//
//            Exercise_22();
//
//            Exercise_23();
//
//            Exercise_24();
//
//            Exercise_25();
//
//            Exercise_26();
//
//            Exercise_27();
//
//            Exercise_28();
//
//            Exercise_29();
//
//            Exercise_30();
//
//            Exercise_31();
//
//            Exercise_32();
//
//            Exercise_33();
//
//            Exercise_34();
//
//            Exercise_35();
//
//            Exercise_36();
        }

        static void Exercise_01()
        {
            // Modify this program to greet you instead of the World!
            Console.WriteLine("What's your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, {0}!", name);
        }

        static void Exercise_02()
        {
            // Modify this program to print Humpty Dumpty riddle correctly
            Console.WriteLine("Humpty Dumpty sat on a wall,");

            Console.WriteLine("Humpty Dumpty had a great fall.");
            Console.WriteLine("All the king's horses and all the king's men");
            Console.WriteLine("Couldn't put Humpty together again.");
        }

        static void Exercise_03()
        {
            // Greet 3 of your classmates with this program, in three separate lines
            // like:
            //
            // Hello, Esther!
            // Hello, Mary!
            // Hello, Joe!
            Console.WriteLine("Enter 3 of your classmates' names:");
            string name_1 = Console.ReadLine();
            string name_2 = Console.ReadLine();
            string name_3 = Console.ReadLine();
            string[] name_list = new[] { name_1, name_2, name_3 };

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Hello, {0} !", name_list[i]);
            }
        }

        static void Exercise_04()
        {
            // Write a program that prints a few details to the terminal window about you
            // It should print each detail to a new line.
            //  - Your name
            //  - Your age
            //  - Your height in meters (as a decimal fraction)
            //
            //  Example output:
            //  John Doe
            //  31
            //  1.87

            Console.WriteLine("Please enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine("Please enter your age:");
            int age = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your height in meters (as a decimal fraction):");
            double height = double.Parse(Console.ReadLine());

            Console.WriteLine(name);
            Console.WriteLine(age);
            Console.WriteLine(height);
        }

        static void Exercise_05()
        {
            // Create a program that prints a few operations on two numbers: 22 and 13

            // Print the result of 13 added to 22

            // Print the result of 13 substracted from 22

            // Print the result of 22 multiplied by 13

            // Print the result of 22 divided by 13 (as a decimal fraction)

            // Print the integer part of 22 divided by 13

            // Print the reminder of 22 divided by 13

            int a = 22;
            int b = 13;
            Console.WriteLine("Result of {0} + {1}: {2}", a, b, a + b);
            Console.WriteLine("Result of {0} - {1}: {2}", a, b, a - b);
            Console.WriteLine("Result of {0} * {1}: {2}", a, b, a * b);
            Console.WriteLine("Result of {0} / {1}: {2}", a, b, (double)a / (double)b);
            Console.WriteLine("Result of {0} / {1}: {2}", a, b, a / b);
            Console.WriteLine("Result of {0} % {1}: {2}", a, b, a % b);
        }

        static void Exercise_06()
        {
            int daily_code_hour = 6;
            int weeks = 17;
            int workdays = 5;
            int weekly_work_hour = 52;
            int code_hour_semester = weeks * workdays * daily_code_hour;

            Console.WriteLine("An attendee spends {0} hours coding in a semester (only in workdays).",
                code_hour_semester);

            Console.WriteLine("If an attendee spent {0} hour(s) coding in a semester, his/her coding hour percentage is {1}%.",
                code_hour_semester, (double)code_hour_semester / (double)workdays * (double)weekly_work_hour / 100);
        }

        static void Exercise_07()
        {
            // Store your favorite number in a variable (as a number)
            // And print it like this: "My favorite number is: 8"
            Console.Write("What's your favorite number: ");
            int fav_num = Int32.Parse(Console.ReadLine());
            Console.WriteLine("My favorite number is: {0}", fav_num);
        }

        static void Exercise_08()
        {
            // Swap the values of the variables
            int a = 123;
            int b = 526;
            Console.WriteLine("Before swap -");
            Console.WriteLine("a = {0}", a);
            Console.WriteLine("b = {0}", b);
            int temp = 0;
            a = temp;
            a = b;
            b = temp;
            Console.WriteLine("After swap -");
            Console.WriteLine("a = {0}", a);
            Console.WriteLine("b = {0}", b);
        }

        static void Exercise_09()
        {
            // Print the Body mass index (BMI) based on these values
            double massInKg = 81.2;
            double heightInM = 1.78;

            Console.WriteLine("BMI = {0}", massInKg / Math.Pow(heightInM, 2));

        }

        static void Exercise_10()
        {
            // Define several things as a variable then print their values
            // Your name as a string
            // Your age as an integer
            // Your height in meters as a double
            // Whether you are married or not as a boolean

            Console.WriteLine("Please enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine("Please enter your age:");
            int age = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your height in meters (as a decimal fraction):");
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine("Are you married or not? Y/N");
            string yes_no = Console.ReadLine();
            if (yes_no == "Y" || yes_no == "y")
            {
                Console.WriteLine(true);
            }
            else if (yes_no == "N" || yes_no == "n")
            {
                Console.WriteLine(false);
            }
        }

        static void Exercise_11()
        {
            int a = 3;
            // make it bigger by 10
            a += 10;
            Console.WriteLine(a);

            int b = 100;
            // make it smaller by 7
            b -= 7;
            Console.WriteLine(b);

            int c = 44;
            // please double c's value
            c *= 2;
            Console.WriteLine(c);

            int d = 125;
            // please divide by 5 d's value
            d /= 5;
            Console.WriteLine(d);

            int e = 8;
            // please cube of e's value
            e *= e;
            Console.WriteLine(e);

            int f1 = 123;
            int f2 = 345;
            // tell if f1 is bigger than f2 (print as a boolean)
            Console.WriteLine(f1 > f2);

            int g1 = 350;
            int g2 = 200;
            // tell if the double of g2 is bigger than g1 (print as a boolean)
            Console.WriteLine(2 * g2 > g1);

            long h = 1357988018575474;
            // tell if 11 is a divisor of h (print as a boolean)
            Console.WriteLine(h % 11 == 0);

            int i1 = 10;
            int i2 = 3;
            // tell if i1 is higher than i2 squared and smaller than i2 cubed (print as a boolean)
            Console.WriteLine(i1 > Math.Pow(i2, 2) && i1 < Math.Pow(i2, 3));

            int j = 1521;
            // tell if j is divisible by 3 or 5 (print as a boolean)
            Console.WriteLine(j % 3 == 0 || j % 5 == 0);

            string k = "Apple";
            //fill the k variable with its content 4 times

            Console.WriteLine(k);
        }

        static void Exercise_12()
        {
            // Write a program that stores 3 sides of a cuboid as variables (doubles)
            // The program should write the surface area and volume of the cuboid like:
            //
            // Surface Area: 600
            // Volume: 1000

            Console.WriteLine("Enter length: ");
            double length = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter width: ");
            double width = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter height: ");
            double height = double.Parse(Console.ReadLine());

            Console.WriteLine("Surface Area: {0}", 2 * ((length * width) + (length * height) + (width * height)));
            Console.WriteLine("Volume: {0}", length * width * height);
        }

        static void Exercise_13()
        {
            int currentHours = 14;
            int currentMinutes = 34;
            int currentSeconds = 42;

            // Write a program that prints the remaining seconds (as an integer) from a
            // day if the current time is represented by the variables

            int remain_sec = 0;

            if (currentHours >= 0 && currentHours <= 24)
            {
                remain_sec = (24 - currentHours) * 3600;

                if (currentMinutes >= 0 && currentMinutes < 60)
                {
                    remain_sec = (24 - currentHours - 1) * 3600 + (60 - currentMinutes) * 60;

                    if (currentSeconds >= 0 && currentSeconds < 60)
                    {
                        remain_sec = (24 - currentHours - 1) * 3600 + (60 - currentMinutes - 1) * 60 + (60 - currentSeconds);
                    }
                }
            }
            Console.WriteLine("The remaining second(s) from today is {0}.", remain_sec);
        }

        static void Exercise_14()
        {
            // Modify this program to greet user instead of the World!
            // The program should ask for the name of the user
            System.Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, {0}!", name);
        }

        static void Exercise_15()
        {
            // Write a program that asks for an integer that is a distance in kilometers,
            // then it converts that value to miles and prints it

            double rate = 0.62137119;
            Console.WriteLine("Please enter a distance in kilometers: ");
            int dis_kilo = Console.Read();
            Console.WriteLine("The distance is {0} in miles.", dis_kilo * rate);
        }

        static void Exercise_16()
        {
            // Write a program that asks for two integers
            // The first represents the number of chickens the farmer has
            // The second represents the number of pigs owned by the farmer
            // It should print how many legs all the animals have
            Console.WriteLine("How many chickens:");
            int chickens = Int32.Parse(Console.ReadLine());
            Console.WriteLine("How many pigs:");
            int pigs = Int32.Parse(Console.ReadLine());
            System.Console.WriteLine("Total legs: {0}", chickens * 2 + pigs * 4);
        }

        static void Exercise_17()
        {
            // Write a program that asks for 5 integers in a row,
            // then it should print the sum and the average of these numbers like:
            //
            // Sum: 22, Average: 4.4
            int[] intArray = new int[5];
            int sum = 0;
            for (int i = 0; i < intArray.Length; i++)
            {
                Console.WriteLine("Enter an integer:");
                int number = Int32.Parse(Console.ReadLine());
                intArray[i] = number;
                sum += number;
            }

            Console.WriteLine("Sum = {0}, Average: {1}", sum, (double)sum/(double)intArray.Length);
        }

        static void Exercise_18()
        {
            // Write a program that reads a number from the standard input,
            // Then prints "Odd" if the number is odd, or "Even" if it is even.
            Console.WriteLine("Enter a number:");
            int number = Int32.Parse(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }
        }

        static void Exercise_19()
        {

            // Write a program that reads a number form the standard input,
            // If the number is zero or smaller it should print: Not enough
            // If the number is one it should print: One
            // If the number is two it should print: Two
            // If the number is more than two it should print: A lot
        }






        public class Functions
        {
            public void ArithmeticAssignmentOperator()
            {
                int c = 12;
                // prints 12
                Console.WriteLine(c++);
                // prints 13
                Console.WriteLine(c);

                int d = 12;
                // prints 13
                Console.WriteLine(++d);
                // prints 13
                Console.WriteLine(d);

                int e = 12;
                // prints 12
                Console.WriteLine(e--);
                // prints 11
                Console.WriteLine(e);

                int f = 12;
                // prints 11
                Console.WriteLine(--f);
                // prints 11
                Console.WriteLine(f);
            }
            
            public void CopyContent()
            {
                string k = "Apple";
                //fill the k variable with its content 4 times
                for (int i = 0; i < 4; i++)
                {
                    k += k;
                }

                Console.WriteLine(k);
            }

            public void Cube()
            {
                int e = 8;
                // please cube of e's value
                e *= (int)Math.Pow(e, 2);
                Console.WriteLine(e);
            }

            public void Division()
            {
                int j = 1521;
                // tell if j is divisible by 3 or 5 (print as a boolean)

                if (j % 3 == 0 || j % 5 == 0)
                {
                    Console.WriteLine(true);
                }
                else
                {
                    Console.WriteLine(false);
                }
            }

            public void PartyIndicator()
            {
                // Write a program that asks for two numbers
                // The first number represents the number of girls that comes to a party, the
                // second the boys
                // It should print: The party is exellent!
                // If the the number of girls and boys are equal and there are more people coming than 20
                //
                // It should print: Quite cool party!
                // It there are more than 20 people coming but the girl - boy ratio is not 1-1
                //
                // It should print: Average party...
                // If there are less people coming than 20
                //
                // It should print: Sausage party
                // If no girls are coming, regardless the count of the people

                Console.WriteLine("Number of girls: ");
                int girls = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Number of boys: ");
                int boys = Int32.Parse(Console.ReadLine());

                if (girls + boys > 20)
                {
                    if (girls == boys)
                    {
                        if (girls == 0)
                        {
                            Console.WriteLine("Sausage party");
                        }
                        else
                        {
                            Console.WriteLine("The party is excellent!");
                        }
                    }
                    else
                    {
                        if (girls == 0)
                        {
                            Console.WriteLine("Sausage party");
                        }
                        else
                        {
                            Console.WriteLine("Quite cool party!");
                        }
                    }
                }
                else if (girls + boys < 20)
                {
                    if (girls == 0)
                    {
                        Console.WriteLine("Sausage party");
                    }
                    else
                    {
                        Console.WriteLine("Average party...");
                    }
                }
                else
                {
                    Console.WriteLine("Not a crowd.");
                }
            }
            
            public void SquareAndCube()
            {
                int i1 = 10;
                int i2 = 3;
                // tell if i1 is higher than i2 squared and smaller than i2 cubed (print as a boolean)
                Boolean boo = (i1 > Math.Pow(i2, 2) && (i1 < Math.Pow(i2, 3)));
                if (boo)
                {
                    Console.WriteLine("i1 is higher than i2 squared and smaller than i2 cubed.");
                }
                else
                {
                    Console.WriteLine("i1 is either smaller than i2 squared or higher than i2 cubed.");
                }
            }

            public void Calculator()
            {
                Console.WriteLine("Welcome to the Calculator!");
                Console.WriteLine("Please provide the first number:");
                int num1 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Please provide the second number:");
                int num2 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Please provide the operation (add, subtract, multiply or divide):");
                string operation = Console.ReadLine();
                double result = 0;
                switch (operation)
                {
                    case "+":
                        result = num1 + num2;
                        break;
                    case "-":
                        result = num1 - num1;
                        break;
                    case "*":
                        result = num1 * num2;
                        break;
                    case "/":
                        result = num1 / num2;
                        break;
                    default:
                        Console.WriteLine("Not an option, please try one of the four operators above.");
                        return;
                }
                Console.WriteLine($"The result is {result}.");
            }

            public void PrintEven()
            {
                for (int i = 0; i <= 500; i += 2)
                {
                    Console.WriteLine(i);
                }
            }

            public void MultiplicationTable()
            {
                Console.WriteLine("What number do you prefer: ");
                int num = Int32.Parse(Console.ReadLine());

                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine("{0} * {1} = {2}", i, num, i * num);
                }
            }

            public void CountFromTo()
            {
                Console.WriteLine("Enter a number: ");
                int num1 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Enter another number: ");
                int num2 = Int32.Parse(Console.ReadLine());

                if (num2 <= num1)
                {
                    Console.WriteLine("The second number should be bigger");
                    Console.WriteLine("Enter the second number: ");
                    num2 = Int32.Parse(Console.ReadLine());
                }
                else
                {
                    for (int i = num1; i < num2; i++)
                    {
                        Console.WriteLine(i);
                    }
                }
            }

            public void FizzBuzz()
            {
                for (int i = 1; i <= 100; i++)
                {
                    if (i % 3 == 0 && i % 5 != 0)
                    {
                        Console.WriteLine("Fizz");
                    }else if (i % 5 == 0 && i % 3 != 0)
                    {
                        Console.WriteLine("Buzz");
                    }else if (i % 3 == 0 && i % 5 == 0)
                    {
                        Console.WriteLine("FizzBuzz");
                    }
                    else
                    {
                        Console.WriteLine(i);
                    }
                }
            }

            public void DrawTriangle()
            {
                Console.WriteLine("Enter a number: ");
                int num = Int32.Parse(Console.ReadLine());

                for (int x = 1; x <= num; x++)
                {
                    for (int y = 0; y <= x - 1; y++)
                    { 
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
