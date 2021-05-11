using System.Collections.Generic;
using MenuApp.InventoryService.Logic.Entity;

namespace MenuApp.InventoryService.Logic.Interfaces
{
    public interface IRecipeRepository
    {
        Recipe AddIngredient(Recipe recipe);
        List<Recipe> GetRecipes();
    }
}