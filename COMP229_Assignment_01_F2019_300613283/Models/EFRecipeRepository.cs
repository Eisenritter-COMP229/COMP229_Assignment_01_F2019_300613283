using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COMP229_Assignment_01_F2019_300613283.Models
{
    public class EFRecipeRepository:IRecipeRepository
    {
        private ApplicationDBContext context;

        // Whenever EFRecipeRepository is created sets the context to the context
        public EFRecipeRepository(ApplicationDBContext ctx)
        {
            context = ctx;
        }
        // Return set of recipes from database
        public IQueryable<Recipe> Recipes => context.Recipes;
    }
}
