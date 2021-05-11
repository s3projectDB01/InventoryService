
namespace Stock.Core
{
    public class IngredientsDBConfig
    {
        public string Database_Name { get; set; } = "InventoryService";
        public string Ingredients_Collection_Name { get; set; } = "Ingredients";
        public string Connection_String { get; set; } = "mongodb://178.62.250.30";
    }
}
