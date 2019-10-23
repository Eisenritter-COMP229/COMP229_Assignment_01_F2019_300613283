using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COMP229_Assignment_01_F2019_300613283.Models
{
    // Use Interface for either Fake Repository, or 
    // Data repository thats associated with database
    public interface IRecipeRepository
    {
        // More Optimized and Better used to query the list of products
        IQueryable<Recipe> Recipes { get; }
    }
}
