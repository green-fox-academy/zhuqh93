using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RecipeStore.Models;

namespace RecipeStore.Services
{
    public interface IHomeServices
    {
        IEnumerable<Recipe> FindAll();
    }
}
