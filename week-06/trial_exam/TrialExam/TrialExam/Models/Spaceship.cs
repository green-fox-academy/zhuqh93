using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrialExam.Models
{
    public class Spaceship
    {
        public long SpaceshipId { get; set; }
        public long Capacity { get; set; }
        public long CurrentPassengers { get; set; }
        public string Location { get; set; }
        public Planet Planets { get; set; }
        public long PlanetId { get; set; }
    }
}
