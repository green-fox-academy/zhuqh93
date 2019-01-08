using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeStore.Models
{
    public class RecipeIngredient
    {
        public long RecipeId { get; set; }
        public Recipe Recipe { get; set; }

        public long IngredientId { get; set; }
        public Ingredient Ingredient { get; set; }
    }
}
