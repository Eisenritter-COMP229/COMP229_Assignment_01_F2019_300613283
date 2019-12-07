using COMP229_Assignment_01_F2019_300613283.Models;
using Microsoft.AspNetCore.Mvc;

namespace COMP229_Assignment_01_F2019_300613283.Controllers
{
    public class RecipeController : Controller
    {
        private IRecipeRepository repository;

        //When RecipeController is called, repository will be created automatically, based on startup
        public RecipeController(IRecipeRepository repo)
        {
            repository = repo;
        }

        // Send the recipes in the repository to the view
        public ViewResult List() => View(repository.Recipes);
    }
}
