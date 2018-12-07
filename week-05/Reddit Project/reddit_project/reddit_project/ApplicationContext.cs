using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using reddit_project.Models;

namespace reddit_project
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }

        public ApplicationContext(DbContextOptions options) : base(options)
        {
        }
    }
}
