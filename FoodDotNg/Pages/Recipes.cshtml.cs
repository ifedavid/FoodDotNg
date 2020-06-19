using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodDotNg.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FoodDotNg.Pages
{
    public class RecipesModel : PageModel
    {
        private readonly FoodDotNgDbContext _context;
        public List<Recipes> Recipes { get; set; }

        public RecipesModel(FoodDotNgDbContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
            Recipes = _context.Recipes.Where(r => r.Status == "Approved").ToList();
        }
    }
}