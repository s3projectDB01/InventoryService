using System;
using System.Collections.Generic;

namespace MenuApp.InventoryService.Logic.Entity
{
    public class Recipe
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public ICollection<IngredientNeeded> IngredientsNeeded { get; set; }
    }
}