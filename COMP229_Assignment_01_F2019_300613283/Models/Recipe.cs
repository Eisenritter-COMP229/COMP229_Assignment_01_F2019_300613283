using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel.DataAnnotations;

namespace COMP229_Assignment_01_F2019_300613283.Models
{
    public class Recipe
    {
        [Required(ErrorMessage = "Please enter recipe Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter recipe Description")]
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public int ID { get; set; }

        public List<Review> Reviews { get; set; }
        public List<Ingredient> Ingredients { get; set; }

        public Recipe()
        {
            this.Ingredients = new List<Ingredient>(this.ID);
            this.Reviews = new List<Review>(this.ID);
            this.ID =RecipeList.Recipes.Count();
        }
        public void addReview(Review review)
        {
            Reviews.Add(review);
        }
        public void addIngredient(Ingredient ingredient)
        {
            Ingredients.Add(ingredient);
        }
    }
}
