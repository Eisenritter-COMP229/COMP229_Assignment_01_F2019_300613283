using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COMP229_Assignment_01_F2019_300613283.Models
{
    public class IngredientList
    {
        private static List<Ingredient> ingredients = new List<Ingredient>();
        public int IngredientID { get; set; }

        public static IEnumerable<Ingredient> Ingredients
        {
            get
            {
                return ingredients;
            }
        }

        public static void AddIngredient(Ingredient ingredient)
        {
            ingredients.Add(ingredient);
        }
    }
}
