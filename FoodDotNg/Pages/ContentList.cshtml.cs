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

            if(pageName == "Interviews")
            {
                var category = allCategories.Where(ac => ac.Name == pageName);
                if(category == null)
                {
                    return NotFound();
                }
                BlogPosts = allArticles.Where(a => a.Status == "Approved" && a.Category == category).OrderBy(ad => ad.DateCreated).ToList();
            }
            
            if(pageName == "Food Life")
            {
                var category = allCategories.Where(ac => ac.Name == pageName);
                if (category == null)
                {
                    return NotFound();
                }
                BlogPosts = allArticles.Where(a => a.Status == "Approved" && a.Category == category).OrderBy(ad => ad.DateCreated).ToList();
            }

            if (pageName == "Latest News")
            {
                var category = allCategories.Where(ac => ac.Name == pageName);
                if (category == null)
                {
                    return NotFound();
                }
                BlogPosts = allArticles.Where(a => a.Status == "Approved" && a.Category == category).OrderBy(ad => ad.DateCreated).ToList();
            }

            if (pageName == "Cooking")
            {
                var category = allCategories.Where(ac => ac.Name == pageName);
                if (category == null)
                {
                    return NotFound();
                }
                BlogPosts = allArticles.Where(a => a.Status == "Approved" && a.Category == category).OrderBy(ad => ad.DateCreated).ToList();
            }


            if (pageName == "Recipes")
            {
                RecipesPosts = _context.Recipes.Where(a => a.Status == "Approved").OrderBy(ad => ad.DateCreated).ToList();
            }

            if (pageName == "Events")
            {
                EventPosts = _context.Events.Where(a => a.Status == "Approved").OrderBy(ad => ad.DateCreated).ToList();
            }

            return Page();
        }
    }
}