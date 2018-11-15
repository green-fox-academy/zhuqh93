using System;
using System.Collections.Generic;
using System.Text;

namespace Green_Fox_inheritance_exercise
{
    class Student : Person
    {
        private string PreviousOrganization { get; set; }
        private int SkippedDays { get; set; }

        internal Student(string name, int age, string gender, string previousOrganization) : base(name, age, gender)
        {
            this.PreviousOrganization = previousOrganization;
            this.SkippedDays = 0;
        }

        internal Student() : base()
        {
            this.PreviousOrganization = "The School of Life";
            this.SkippedDays = 0;
        }
        
        internal override void Introduce()
        {
            Console.WriteLine("Hi, I'm {0}, a {1} year old {2} from {3} " +
                              "who skipped {4} days from the course already.",
                Name, Age, Gender,PreviousOrganization, SkippedDays);
        }

        internal override void GetGoal()
        {
            Console.WriteLine("Be a junior software developer");
        }

        internal void SkipDays(int numberOfDays)
        {
            SkippedDays += numberOfDays;
        }
    }
}
