using Frontend.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frontend
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Log> Logs { get; set; }

        public ApplicationContext(DbContextOptions options) : base(options)
        {
        }
    }
}
