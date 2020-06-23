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

        public ArticleCategories Category { get; set; }

        public int CurrentPage { get; set; } = 1;

        public int Count { get; set; }

        public int PageSize { get; set; } = 9;

        public int TotalPages => (int)Math.Ceiling(decimal.Divide(Count, PageSize));

        public bool EnablePrevious => CurrentPage > 1;

        public bool EnableNext => CurrentPage < TotalPages;
        [BindProperty]
        public List<Articles> BlogPosts { get; set; }

        public IActionResult OnGet(string pageName, int currentPage)
        {
            PageName = pageName;
            var allArticles = _context.Articles.ToList();
            var allCategories = _context.ArticleCategories.ToList();

           foreach(var category in allCategories)
            {
                if (pageName == category.Name)
                {
                    Category = category;
                    CurrentPage = currentPage == 0 ? 1 : currentPage;

                    Count = _context.Articles.Count();

                    if (CurrentPage > TotalPages)
                        CurrentPage = TotalPages;

                    BlogPosts = _context.Articles.Where(a => a.Status == "Approved" && a.CategoryId == category.Id)
                        .Skip((CurrentPage - 1) * PageSize)
                        .Take(PageSize)
                        .OrderBy(e => e.DateCreated)
                        .ToList();
                }
            }

            return Page();
        }
    }
}