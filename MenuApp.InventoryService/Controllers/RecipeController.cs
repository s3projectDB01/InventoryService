using System;
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
            recipe.Id = Guid.NewGuid().ToString();
            _recipeRepository.AddIngredient(recipe);
            return CreatedAtRoute("", new { id = recipe.Title }, recipe);
        }
        
        [HttpGet("getRecipes")]
        public IActionResult GetRecipes()
        {
            return Ok(_recipeRepository.GetRecipes());
        }
        
        [HttpDelete("delete/{id}")]
        public IActionResult DeleteRecipe(string id)
        {
            _recipeRepository.DeleteRecipe(id);
            return NoContent();
        }
        [HttpPut("updateRecipe")]
        public IActionResult UpdateRecipe(Recipe recipe)
        {
            return Ok(_recipeRepository.UpdateRecipe(recipe));
        }
    }
}