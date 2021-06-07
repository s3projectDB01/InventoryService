using System.Collections.Generic;
using System.Threading.Tasks;
using MenuApp.InventoryService.Logic.Entity;
using MenuApp.InventoryService.Logic.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MenuApp.InventoryService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RecipeController : ControllerBase
    {
        private readonly IRecipeRepository _recipeRepository;

        public RecipeController(IRecipeRepository repository)
        {
            _recipeRepository = repository;
        }
        
        [HttpPost]
        public void CreateRecipe(Recipe recipe) 
        {
            _recipeRepository.CreateNewRecipe(recipe);
        }
        [HttpGet("GetAll")]
        public async Task<List<Recipe>> GetAl()
        {
            return await _recipeRepository.GetAllRecipes();
        }
        [HttpPut]
        public async Task<IActionResult> Update(Recipe recipe)
        {
            await _recipeRepository.UpdateRecipe(recipe);
            return Ok(recipe);
        }
        [HttpPut("Update/ingredient")]
        public async Task<IActionResult> UpdateIngredient(IngredientNeeded ingredient)
        {
            await _recipeRepository.UpdateIngredient(ingredient);
            return Ok(ingredient);
        }
    }
}