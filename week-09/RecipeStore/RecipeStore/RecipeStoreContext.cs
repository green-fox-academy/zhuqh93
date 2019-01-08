using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RecipeStore.Models;

namespace RecipeStore
{
    public class RecipeStoreContext : DbContext
    {
        public DbSet<Recipe> Recipes { get; set; }
        
        public RecipeStoreContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RecipeIngredient>()
                .HasKey(ri => new { ri.IngredientId, ri.RecipeId });
        }
    }
}
