using System.Collections.Generic;
using MenuApp.InventoryService.Logic.Entity;

namespace MenuApp.InventoryService.Logic.Interfaces
{
    public interface IRecipeRepository
    {
        Recipe AddIngredient(Recipe recipe);
        List<Recipe> GetRecipes();
        void DeleteRecipe(string id);
        Recipe GetRecipe(string id);
        Recipe UpdateRecipe(Recipe recipe);
    }
}