using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using COMP229_Assignment_01_F2019_300613283.Models;

namespace COMP229_Assignment_01_F2019_300613283.Controllers
{
    public class RecipeController : Controller
    {
        private IRecipeRepository repository;

        //Fake repository will be created whenever 
        //this constructor is called
        public RecipeController(IRecipeRepository repo)
        {
            repository = repo;
        }

        // Send the recipes in the repository to the view
        public ViewResult List() => View(repository.Recipes);
    }
}
