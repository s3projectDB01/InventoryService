using System;
using System.Collections.Generic;

namespace MenuApp.InventoryService.Logic.Entity
{
    public class Ingredient
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int AmountNeeded { get; set; }
    }
}
