using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COMP229_Assignment_01_F2019_300613283.Models
{
    public class FakeRecipeRepository : IRecipeRepository
    {
        public IQueryable<Recipe> Recipes => new List<Recipe>
        {
            new Recipe {Name = "Rosemary and Garlic Roasted Leg of Lamb",
            Description="Rosemary and Garlic Roasted Leg of Lamb – a classic yet simple recipe for a perfectly roasted leg of lamb with an aromatic garlic, rosemary and mustard"},
            new Recipe {Name = "Smoked Salmon Pasta",
            Description="A Pasta with smoked salmon"},
            new Recipe {Name = "Unagi Fried Rice",
            Description="A deluxe fried rice with egg, shrimp, chicken, pork, unagi and topped off with tobiko and masako"},
            new Recipe {Name = "Herbal Chicken Soup",
            Description="A simple chicken soup stewed with black fungus and many oriental medicinal herbs, cures your cold in no time!" },
            new Recipe {Name = "Bacon & Egg",
            Description="A classic english breakfast with bacon, egg and toast"}

        }.AsQueryable<Recipe>(); //This method converts this list to an IQueryable of type Recipe
    }
}
