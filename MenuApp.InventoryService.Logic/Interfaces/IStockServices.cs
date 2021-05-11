using System;
using System.Collections.Generic;
using System.Text;

namespace Stock.Core
{
    public interface IStockServices
    {
        List<Ingredient> GetIngredients();
        Ingredient GetIngredient(string id);
        Ingredient AddIngredient(Ingredient ingredient);
        void DeleteIngredient(string id);
        Ingredient UpdateIngredient(Ingredient ingredient);
    }
}
