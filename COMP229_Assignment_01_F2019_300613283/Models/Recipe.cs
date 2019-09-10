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
        public string Description { get; set; }
        public Image Image { get; set; }
        private static List<Ingredient> ingredients = new List<Ingredient>(); 
        
        public static void AddIngredient(Ingredient ingredient)
        {
            ingredients.Add(ingredient);
        }
  
    }
}
