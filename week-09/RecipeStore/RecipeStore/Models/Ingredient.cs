using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeStore.Models
{
    public class Ingredient
    {
        public long IngredientId { get; set; }
        public string Amount { get; set; }
        public string Unit { get; set; }
        public string Name { get; set; }
        public ICollection<RecipeIngredient> RecipeIngredients { get; set; }
    }
}
