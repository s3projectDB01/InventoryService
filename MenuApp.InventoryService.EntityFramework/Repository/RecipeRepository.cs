using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MenuApp.InventoryService.Logic.Entity;
using MenuApp.InventoryService.Logic.Interfaces;
using MenuApp.InventoryService.Persistance.Data;
using Microsoft.EntityFrameworkCore;

namespace MenuApp.InventoryService.Persistance.Repository
{
    public class RecipeRepository : IRecipeRepository
    {
        private readonly AppDbContext _db;

        public RecipeRepository(AppDbContext db)
        {
            _db = db;
        }
        public void CreateNewRecipe(Recipe recipe)
        {
            if (recipe != null)
            {
                _db.Recipes.Add(recipe);
                _db.SaveChanges();
            }
        }
        public async Task<List<Recipe>> GetAllRecipes()
        {
            return await _db.Recipes
                .Include(x => x.IngredientsNeeded)
                .ToListAsync();
        }
        public async Task<Recipe> UpdateRecipe(Recipe recipe)
        {
            _db.Recipes.Update(recipe);
            await _db.SaveChangesAsync();
            return recipe;
        }
        public async Task<IngredientNeeded> UpdateIngredient(IngredientNeeded ingredientNeeded)
        {
            _db.IngredientsNeeded.Update(ingredientNeeded);
            await _db.SaveChangesAsync();
            return ingredientNeeded;
        }
    }
}
