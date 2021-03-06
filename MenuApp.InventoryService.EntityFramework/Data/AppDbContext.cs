using MenuApp.InventoryService.Logic.Entity;
using Microsoft.EntityFrameworkCore;

namespace MenuApp.InventoryService.Persistance.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<IngredientNeeded> IngredientsNeeded { get; set; }
        public DbSet<Recipe> Recipes { get; set; }

    }
}