using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrialExam.Models;

namespace TrialExam.ViewModels
{
    public class SpaceTransporterViewModel
    {
        public Spaceship Spaceship { get; set; }
        public List<Planet> PlanetList { get; set; }
    }
}
