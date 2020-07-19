using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodDotNg.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FoodDotNg.Pages
{
    public class RecipePostModel : PageModel
    {
        private readonly FoodDotNgDbContext _context;

        [BindProperty]
        public Guid PostId { get; set; }
        public Recipes BlogPost { get; set; }
        public List<Recipes> Recipes { get; set; }
        public RecipePostModel(FoodDotNgDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> OnGet(Guid postId)
        {
            Recipes = _context.Recipes.Where(r=> r.Status == "Approved").ToList();
            BlogPost = await _context.Recipes.FindAsync(postId);
            if (BlogPost == null)
            {
                return NotFound();
            }
            Recipes.Remove(BlogPost);

            return Page();

        }
    }
}