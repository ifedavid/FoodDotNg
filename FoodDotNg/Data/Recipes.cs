using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDotNg.Data
{
    public class Recipes: BaseModel
    {
        public string Ingredients { get; set; }
        public string Steps { get; set; }
        public string RecipePost { get; set; }
    }
}
