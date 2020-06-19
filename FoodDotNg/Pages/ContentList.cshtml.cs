using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodDotNg.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Routing;

namespace FoodDotNg.Pages
{
    public class ContentListModel : PageModel
    {
        private readonly FoodDotNgDbContext _context;
        public ContentListModel(FoodDotNgDbContext context)
        {
            _context = context;
        }
        public string PageName { get; set; }

        [BindProperty]
        public List<Articles> BlogPosts { get; set; }
        public List<Events> EventPosts { get; set; }
        public List<Recipes> RecipesPosts { get; set; }

        public IActionResult OnGet(string pageName)
        {
            PageName = pageName;
            var allArticles = _context.Articles.ToList();
            var allCategories = _context.ArticleCategories.ToList();

           foreach(var category in allCategories)
            {
                if (pageName == category.Name)
                {
                    BlogPosts = allArticles.Where(a => a.CategoryId == category.Id && a.Status == "Approved").ToList();
                }
            }

            return Page();
        }
    }
}