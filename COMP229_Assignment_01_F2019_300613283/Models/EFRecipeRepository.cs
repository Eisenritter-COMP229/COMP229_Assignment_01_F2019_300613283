using System.Linq;

namespace COMP229_Assignment_01_F2019_300613283.Models
{
    // Entity Framework Recipe Repository
    // This is the Repository Class using the Database class
    public class EFRecipeRepository:IRecipeRepository
    {
        private ApplicationDBContext context;

        // Whenever EFRecipeRepository is created sets the context to the context
        public EFRecipeRepository(ApplicationDBContext ctx)
        {
            context = ctx;
        }
        // The Recipes are set to the Recipes in the database
        public IQueryable<Recipe> Recipes => context.Recipes;
    }
}
