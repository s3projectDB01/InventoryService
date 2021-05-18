using Stock.Core;
using Microsoft.AspNetCore.Mvc;

namespace Stock.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class IngredientController : ControllerBase
    {
        // private readonly IStockServices _stockServices;
        //
        // public IngredientController(IStockServices stockServices)
        // {
        //     _stockServices = stockServices;
        // }
        //
        // [HttpGet]
        // public IActionResult GetIngredients()
        // {
        //     return Ok(_stockServices.GetIngredients());
        // }
        //
        // [HttpGet("{id}", Name ="GetIngredient")]
        // public IActionResult GetIngredient(string id)
        // {
        //     return Ok(_stockServices.GetIngredient(id));
        // }
        //
        // [HttpPost]
        // public IActionResult AddIngredient(Ingredient ingredient)
        // {
        //     _stockServices.AddIngredient(ingredient);
        //     return CreatedAtRoute("GetIngredient", new { id = ingredient.Name }, ingredient);
        // }
        //
        // [HttpDelete("{id}")]
        // public IActionResult DeleteIngredient(string id)
        // {
        //     _stockServices.DeleteIngredient(id);
        //     return NoContent();
        // }
        //
        // [HttpPut]
        // public IActionResult UpdateIngredient(Ingredient ingredient)
        // {
        //     return Ok(_stockServices.UpdateIngredient(ingredient));
        // }
    }
}
