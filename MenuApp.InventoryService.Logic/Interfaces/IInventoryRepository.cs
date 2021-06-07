using System.Collections.Generic;
using System.Threading.Tasks;
using MenuApp.InventoryService.Logic.Entity;

namespace MenuApp.InventoryService.Logic.Interfaces
{
    public interface IInventoryRepository
    {
        void CreateNewIngredient(Ingredient ingredient);
        Task<Ingredient> UpdateIngredient(Ingredient ingredient);
        void DeleteIngredient(Ingredient ingredient);
        Task<List<Ingredient>> GetAllIngredients();
    }
}