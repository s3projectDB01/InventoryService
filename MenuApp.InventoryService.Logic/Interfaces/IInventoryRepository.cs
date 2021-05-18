using System.Threading.Tasks;
using MenuApp.InventoryService.Logic.Entity;
using Microsoft.AspNetCore.Mvc;

namespace MenuApp.InventoryService.Logic.Interfaces
{
    public interface IInventoryRepository
    {
        void CreateNewIngredient(Ingredient ingredient);
        Task<Ingredient> UpdateIngredient(Ingredient ingredient);
    }
}