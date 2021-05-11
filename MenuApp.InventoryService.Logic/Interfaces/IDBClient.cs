using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MenuApp.InventoryService.Logic.Entity;

namespace Stock.Core
{
    public interface IDBClient
    {
        IMongoCollection<Recipe> GetRecipeCollection();
    }
}
