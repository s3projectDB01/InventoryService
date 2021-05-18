using System.Threading.Tasks;
using MenuApp.InventoryService.Logic.Entity;
using MenuApp.InventoryService.Logic.Interfaces;
using MenuApp.InventoryService.Persistance.Data;

namespace MenuApp.InventoryService.Persistance.Repository
{
    public class InventoryRepository : IInventoryRepository
    {
        private readonly AppDbContext _db;

        public InventoryRepository(AppDbContext db)
        {
            _db = db;
        }
        
        public void CreateNewIngredient(Ingredient ingredient)
        {
            if (ingredient != null) 
            {
                _db.Ingredients.Add(ingredient);
                _db.SaveChanges();
            }
        }
        
        public async Task<Ingredient> UpdateIngredient(Ingredient ingredient)
        {
            _db.Ingredients.Update(ingredient);
            await _db.SaveChangesAsync();
            return ingredient;
        }

        public void DeleteIngredient(Ingredient ingredient)
        {
            _db.Ingredients.Remove(ingredient);
            _db.SaveChanges();
        }
    }
}