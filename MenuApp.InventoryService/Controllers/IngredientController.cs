using System.Collections.Generic;
using System.Threading.Tasks;
using MenuApp.InventoryService.Logic.Entity;
using MenuApp.InventoryService.Logic.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MenuApp.InventoryService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class IngredientController : ControllerBase
    {
        private readonly IInventoryRepository _inventoryRepository;
        
        public IngredientController(IInventoryRepository inventoryRepository) 
        {
            _inventoryRepository = inventoryRepository;
        }
        
        [HttpPost]
        public void CreateIngredient(Ingredient ingredient) 
        {
            _inventoryRepository.CreateNewIngredient(ingredient);
        }
        
        [HttpPost("CreateMultiple")]
        public void CreateMultipleIngredient(List<Ingredient> ingredients)
        {
            foreach(var ingredient in ingredients)
            {
                _inventoryRepository.CreateNewIngredient(ingredient);
            }
        }
        
        [HttpGet("GetAll")]
        public async Task<List<Ingredient>> GetAl()
        {
            return await _inventoryRepository.GetAllIngredients();
        }
        [HttpPut]
        public async Task<IActionResult> Update(Ingredient ingredient)
        {
            await _inventoryRepository.UpdateIngredient(ingredient);
            return Ok(ingredient);
        }
        
        [HttpDelete]
        public void Delete(Ingredient ingredient)
        {
            _inventoryRepository.DeleteIngredient(ingredient);
        }
        
    }
}
