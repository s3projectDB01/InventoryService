using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MenuApp.InventoryService.Logic.Entity;

namespace MenuApp.InventoryService.Logic.Interfaces
{
    public interface IRecipeRepository
    {
        void CreateNewRecipe(Recipe recipe);
        Task<List<Recipe>> GetAllRecipes();
        Task<Recipe> UpdateRecipe(Recipe recipe);
        Task<IngredientNeeded> UpdateIngredient(IngredientNeeded ingredientNeeded);
        Task<Recipe> DeleteRecipe(Guid recipeId);
    }
}