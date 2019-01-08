using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RecipeStore.Models;

namespace RecipeStore.Services
{
    public class HomeServices : IHomeServices
    {
        private readonly RecipeStoreContext _recipeStoreContext;

        public HomeServices(RecipeStoreContext recipeStoreContext)
        {
            _recipeStoreContext = recipeStoreContext;
        }

        public IEnumerable<Recipe> FindAll()
        {
            return _recipeStoreContext.Recipes;
        }
    }
}
