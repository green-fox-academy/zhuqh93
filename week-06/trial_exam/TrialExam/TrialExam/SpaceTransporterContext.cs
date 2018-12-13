using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TrialExam.Models;

namespace TrialExam
{
    public class SpaceTransporterContext : DbContext
    {
        public DbSet<Planet> Planets { get; set; }
        public DbSet<Spaceship> Spaceships { get; set; }

        public SpaceTransporterContext(DbContextOptions options) : base(options)
        {
        }
    }
}
