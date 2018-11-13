using System;
using System.Collections.Generic;
using System.Text;

namespace week02_day02
{
    class Fleet
    {
        private List<Thing> Things;

        public Fleet()
        {
            Things = new List<Thing>();
        }

        public void Add(Thing thing)
        {
            Things.Add(thing);
        }
        
        public List<Thing> GetThings()
        {
            return Things;
        }
    }
}
