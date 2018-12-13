using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrialExam.Models
{
    public class Planet
    {
        public long PlanetId { get; set; }
        public string Name { get; set; }
        public long Population { get; set; }
        public Spaceship Spaceship { get; set; }
    }
}
