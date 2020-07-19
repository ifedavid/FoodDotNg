using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodDotNg.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FoodDotNg.Pages
{
 
    public class BlogPostModel : PageModel
    {
        private readonly FoodDotNgDbContext _context;

        [BindProperty]
        public Guid PostId { get; set; }
        public Articles BlogPost { get; set; }
        public List<Articles> AllArticles { get; set; }
        public BlogPostModel(FoodDotNgDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> OnGet(Guid postId)
        {
            AllArticles = _context.Articles.Where(a => a.Status == "Approved").ToList();
            BlogPost =  await _context.Articles.FindAsync(postId);
            if(BlogPost == null)
            {
                return NotFound();
            }
            AllArticles.Remove(BlogPost);
            return Page();

        }
    }
}