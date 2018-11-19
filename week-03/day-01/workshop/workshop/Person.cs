using System;
using System.Collections.Generic;
using System.Text;

namespace workshop
{
    class Person
    {
        internal string Name { get; set; }
        internal int Age { get; set; }
        internal string Gender { get; set; }

        internal Person(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        internal Person()
        {
            this.Name = "Jane Doe";
            this.Age = 30;
            this.Gender = "female";
        }

        internal virtual void Introduce()
        {
            Console.WriteLine("Hi, I'm {0}, a {1} year old {2}.",
                Name, Age, Gender);
        }

        internal virtual void GetGoal()
        {
            Console.WriteLine("My goal is: Live for the moment!");
        }
    }
}
