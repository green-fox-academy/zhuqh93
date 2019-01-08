using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeStore.Models
{
    public class Recipe
    {
        public long RecipeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Ingredient> Ingredients { get; set; }
        public ICollection<RecipeIngredient> RecipeIngredients { get; set; }
    }
}
