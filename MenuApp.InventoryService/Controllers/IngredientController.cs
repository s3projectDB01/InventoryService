using MenuApp.InventoryService.Logic.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Stock.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class IngredientController : ControllerBase
    {
        private readonly IInventoryRepository _stockServices;
        
    }
}
