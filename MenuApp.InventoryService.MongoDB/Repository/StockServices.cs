using MongoDB.Driver;
using System.Collections.Generic;

namespace Stock.Core
{
    public class StockServices : IStockServices
    { 
        private readonly IMongoCollection<Ingredient> _ingredients;

        public StockServices(IDBClient dbClient)
        {
            //_ingredients = dbClient.GetIngredientCollection();
        }

        public Ingredient AddIngredient(Ingredient ingredient)
        {
            _ingredients.InsertOne(ingredient);
            return ingredient;
        }

        public void DeleteIngredient(string id)
        {
            _ingredients.DeleteOne(ingredient => ingredient.Id == id);
        }

        public Ingredient GetIngredient(string id)
        {
            return _ingredients.Find(ingredient => ingredient.Id == id).First();
        }

        public List<Ingredient> GetIngredients()
        {
            return _ingredients.Find(ingredient => true).ToList();
        }

        public Ingredient UpdateIngredient(Ingredient ingredient)
        {
            GetIngredient(ingredient.Id);
            _ingredients.ReplaceOne(i => i.Id == ingredient.Id, ingredient);
            return ingredient;
        }
    }
}
