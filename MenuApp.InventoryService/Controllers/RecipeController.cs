using MenuApp.InventoryService.Logic.Entity;
using MenuApp.InventoryService.Logic.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Stock.Core;

namespace MenuApp.InventoryService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RecipeController : ControllerBase
    {
        private readonly IRecipeRepository _recipeRepository;
        
        public RecipeController(IRecipeRepository recipeRepository)
        {
            _recipeRepository = recipeRepository;
        }
        
        [HttpPost]
        public IActionResult AddIngredient(Recipe recipe)
        {
            _recipeRepository.AddIngredient(recipe);
            return CreatedAtRoute("", new { id = recipe.Title }, recipe);
        }
        
        // [HttpGet]
        // public IActionResult GetIngredients()
        // {
        //     return Ok(_recipeRepository.GetRecipes());
        // }
    }
}