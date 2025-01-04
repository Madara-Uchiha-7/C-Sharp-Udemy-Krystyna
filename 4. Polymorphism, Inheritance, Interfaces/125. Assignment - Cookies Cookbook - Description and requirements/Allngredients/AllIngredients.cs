using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _125._Assignment___Cookies_Cookbook___Description_and_requirements.Allngredients
{
    internal class AllIngredients
    {
        public Dictionary<int, Ingredient> ingredients = new Dictionary<int, Ingredient>() {
            { 1, new Ingredient(1, "Wheat flour") },
            { 2, new Ingredient(2, "Coconut flour") },
            { 3, new Ingredient(3, "Butter") },
            { 4, new Ingredient(4, "Chocolate") },
            { 5, new Ingredient(5, "Sugar") },
            { 6, new Ingredient(6, "Cardamom") },
            { 7, new Ingredient(7, "Cinnamon") },
            { 8, new Ingredient(8, "Cocoapowder") }
        };
        // Above dict can be written same as
        public Dictionary<int, Ingredient> ingredients_copy = new Dictionary<int, Ingredient>() {
            [1] = new Ingredient(1, "Wheat flour") ,
            [2] = new Ingredient(2, "Coconut flour"),
            [3] = new Ingredient(3, "Butter"),
            [4] = new Ingredient(4, "Chocolate"),
            [5] = new Ingredient(5, "Sugar"),
            [6] = new Ingredient(6, "Cardamom"),
            [7] = new Ingredient(7, "Cinnamon"),
            [8] = new Ingredient(8, "Cocoapowder")
        };
    }
}
