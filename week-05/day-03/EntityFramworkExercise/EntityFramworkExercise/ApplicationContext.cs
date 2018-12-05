using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EntityFramworkExercise.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFramworkExercise
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Todo> Todos { get; set; }

        public ApplicationContext(DbContextOptions options) : base(options)
        {
        }
    }
}
