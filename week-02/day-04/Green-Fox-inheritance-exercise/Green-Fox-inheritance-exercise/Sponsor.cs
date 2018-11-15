using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Green_Fox_inheritance_exercise
{
    class Sponsor : Person
    {
        private string Company { get; set; }
        private int HiredStudents { get; set; }

        internal Sponsor(string name, int age, string gender, string company) : base(name, age, gender)
        {
            this.Company = company;
            this.HiredStudents = 0;
        }

        internal Sponsor() : base()
        {
            Company = "Google";
            HiredStudents = 0;
        }

        internal override void Introduce()
        {
            Console.WriteLine("Hi, I'm {0}, a {1} year old {2} " +
                              "who represents {3} and hired {4} " +
                              "students so far.", Name, Age, Gender, Company, HiredStudents);
        }

        internal void Hire()
        {
            HiredStudents++;
        }

        internal override void GetGoal()
        {
            Console.WriteLine("Hire brilliant junior software developers.");
        }
    }
}
