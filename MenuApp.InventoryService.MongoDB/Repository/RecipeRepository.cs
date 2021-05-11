using System.Collections.Generic;
using MenuApp.InventoryService.Logic.Entity;
using MenuApp.InventoryService.Logic.Interfaces;
using MongoDB.Driver;

namespace Stock.Core.Repository
{
    public class RecipeRepository : IRecipeRepository
    {
        private readonly IMongoCollection<Recipe> _recipes;
        
        public RecipeRepository(IDBClient dbClient)
        {
            _recipes = dbClient.GetRecipeCollection();
        }
        
        public Recipe AddIngredient(Recipe recipe)
        {
            _recipes.InsertOne(recipe);
            return recipe;
        }
        public List<Recipe> GetRecipes()
        {
            return _recipes.Find(recipe => true).ToList();
        }
    }
}