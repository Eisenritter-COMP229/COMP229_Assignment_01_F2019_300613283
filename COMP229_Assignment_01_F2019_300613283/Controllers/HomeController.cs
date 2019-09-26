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

        [HttpGet]
        public ViewResult ViewRecipe(int ID)
        {
            return View("ViewRecipe", Models.RecipeList.Recipes.ElementAt<Recipe>(ID));
        }


        [HttpGet]
        public ViewResult ReviewRecipe()
        {
            return View();
        }


        [HttpPost]
        public ActionResult ReviewRecipe(Review review)
        {
            Review newReview = new Review();

            newReview.RecipeReview = (review.RecipeReview);

            Recipe recipe = Models.RecipeList.Recipes.ElementAt(review.ID);
            recipe.addReview(review);
            return View("ViewRecipe",recipe);
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

        [HttpGet]
        public ViewResult AddIngredient()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddIngredient(Ingredient ingredient)
        {
            Ingredient newIngredient = new Ingredient();
            newIngredient.Name = ingredient.Name;
            ingredient.Amount = ingredient.Amount;

            Recipe recipe = Models.RecipeList.Recipes.ElementAt(ingredient.ID);

            if (ModelState.IsValid)
            {
                recipe.addIngredient(ingredient);
                return View("ViewRecipe", recipe);
            }
            else
            {
                return View();
            }
        }

        //[HttpPost]
        //public ActionResult ReviewRecipe(Review reviewModel)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        //Create new review
        //        Review review1 = new Review();
        //        //Map new review to model
        //        review1.RecipeReview = reviewModel.RecipeReview;

        //    }
        //    return RedirectToAction("ViewRecipe");
        //}

    }
}