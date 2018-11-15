using System;
using System.Collections.Generic;
using System.Text;

namespace Green_Fox_inheritance_exercise
{
    class Mentor : Person
    {
        private string Level { get; set; }

        internal Mentor(string name, int age, string gender, string level) : base(name, age, gender)
        {
            this.Level = level;
        }

        internal Mentor() : base()
        {
            this.Level = "intermediate";
        }

        internal override void GetGoal()
        {
            Console.WriteLine("Educate brilliant junior software developers.");
        }

        internal override void Introduce()
        {
            Console.WriteLine("Hi, I'm {0}, a {1} year old {2} {3} mentor.", 
                                Name, Age, Gender, Level);
        }
    }
}
