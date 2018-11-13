using System;
using System.Collections.Generic;
using System.Text;

namespace week02_day02
{
    class Thing
    {
        private string Name;

        private bool Completed;

        public Thing(string name)
        {
            this.Name = name;
        }

        public void Complete()
        {
            this.Completed = true;
        }

        public string GetName()
        {
            return Name;
        }

        public bool IsCompleted()
        {
            return Completed;
        }
    }
}
