using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using COMP229_Assignment_01_F2019_300613283.Models;
using Microsoft.AspNetCore.Mvc;


namespace COMP229_Assignment_01_F2019_300613283.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }

        public ViewResult RecipeList()
        {
            return View(Models.RecipeList.Recipes);
        }

        public ViewResult ViewRecipe()
        {
            return View();
        }

        public ViewResult ReviewRecipe()
        {
            return View();
        }

        [HttpGet]
        public ViewResult AddRecipe()
        {
            return View();
        }

        [HttpPost]
        public ViewResult AddRecipe(Recipe recipe)
        {
            if (ModelState.IsValid)
            {
               Models.RecipeList.AddRecipe(recipe);
               return View("ViewRecipe",recipe);
            }
            else
            {
                return View();
            }
        }

    }
}