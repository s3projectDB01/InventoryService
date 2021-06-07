using System;
using System.Collections.Generic;

namespace MenuApp.InventoryService.Logic.Entity
{
    public class IngredientNeeded
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int AmountNeeded { get; set; }
        
        public ICollection<Recipe> Recipes { get; set; }
    }
}