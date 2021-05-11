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
        public void DeleteRecipe(string id)
        {
            _recipes.DeleteOne(recipe => recipe.Id == id);
        }
        public Recipe GetRecipe(string id)
        {
            return _recipes.Find(recipe => recipe.Id == id).First();
        }
        public Recipe UpdateRecipe(Recipe recipe)
        {
            GetRecipe(recipe.Id);
            _recipes.ReplaceOne(i => i.Id == recipe.Id, recipe);
            return recipe;
        }
    }
}