using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using Stock.Core;

namespace MenuApp.InventoryService.Logic.Entity
{
    public class Recipe
    {
        [BsonId]
        public string Id { get; set; }
        public string Title { get; set; }
        public List<Ingredient> Ingredients { get; set; } = new List<Ingredient>();
    }
}