using MenuApp.InventoryService.Logic.Entity;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace Stock.Core
{
    public class DBClient : IDBClient
    {
        private readonly IMongoCollection<Recipe> _recipes;
        
        public DBClient(IOptions<RecipesDBConfig> recipesDBConfig)
        {
            var client = new MongoClient(recipesDBConfig.Value.Connection_String);
            var database = client.GetDatabase(recipesDBConfig.Value.Database_Name);
            _recipes = database.GetCollection<Recipe>(recipesDBConfig.Value.Ingredients_Collection_Name);
        }

        public IMongoCollection<Recipe> GetRecipeCollection()
        {
            return _recipes;
        }
    }
}
