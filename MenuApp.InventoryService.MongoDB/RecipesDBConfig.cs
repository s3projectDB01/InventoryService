namespace Stock.Core
{
    public class RecipesDBConfig
    {
        public string Database_Name { get; set; } = "InventoryService";
        public string Ingredients_Collection_Name { get; set; } = "Recipes";
        public string Connection_String { get; set; } = "mongodb://178.62.250.30";
    }
}