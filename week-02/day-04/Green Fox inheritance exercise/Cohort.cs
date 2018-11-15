using System;
using System.Collections.Generic;
using System.Text;

namespace Green_Fox_inheritance_exercise
{
    class Cohort
    {
        private string name = nameof(Cohort);
        private List<Student> students;
        private List<Mentor> mentors;

        internal Cohort(string name)
        {
            this.name = name;
            students = new List<Student>();
            mentors = new List<Mentor>();
        }

        internal void AddStudent(Student student)
        {
            students.Add(student);
        }

        internal void AddMentor(Mentor mentor)
        {
            mentors.Add(mentor);
        }

        internal void Info()
        {
            Console.WriteLine("The {0} cohort has {1} students and {2} mentors.",
                             name, students.Count, mentors.Count);
        }
    }
}
