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

        public int CurrentPage { get; set; } = 1;

        public int Count { get; set; }

        public int PageSize { get; set; } = 9;

        public int TotalPages => (int)Math.Ceiling(decimal.Divide(Count, PageSize));

        public bool EnablePrevious => CurrentPage > 1;

        public bool EnableNext => CurrentPage < TotalPages;
        public List<Recipes> Recipes { get; set; }

        public RecipesModel(FoodDotNgDbContext context)
        {
            _context = context;
        }
        public void OnGet(int currentPage)
        {

            CurrentPage = currentPage == 0 ? 1 : currentPage;

            Count = _context.Recipes.Count();

            if (CurrentPage > TotalPages)
                CurrentPage = TotalPages;

            Recipes = _context.Recipes.Where(r => r.Status == "Approved")
                .Skip((CurrentPage - 1) * PageSize)
                .Take(PageSize)
                .OrderBy(e => e.DateCreated)
                .ToList();
        }
    }
}