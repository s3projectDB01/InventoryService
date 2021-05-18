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
    }
}