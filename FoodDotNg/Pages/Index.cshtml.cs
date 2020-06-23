using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodDotNg.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace FoodDotNg.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly FoodDotNgDbContext _context;
        public List<Articles> AllArticles { get; set; }
        public List<Events> IndexEvents { get; set; }
        public List<Recipes> IndexRecipe { get; set; }
        public Articles InterviewArticle { get; set; }
        public List<Articles> SliderArticles { get; set; }
        public List<Articles> PopularPost { get; set; }
        public IndexModel(ILogger<IndexModel> logger, FoodDotNgDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public void OnGet()
        {
            var category = _context.ArticleCategories.Where(c => c.Name == "Interviews").FirstOrDefault();

            AllArticles = _context.Articles.Where(a => a.Status == "Approved").ToList();

            InterviewArticle = AllArticles.Where(ia => ia.CategoryId == category.Id).FirstOrDefault();

            PopularPost = AllArticles.OrderBy(pp => pp.Id).Take(6).ToList();

            SliderArticles = AllArticles.OrderBy(ca => ca.DateCreated).Take(5).ToList();

            IndexEvents = _context.Events.Where(e => e.Status == "Approved" && e.StartDate >= DateTime.UtcNow).OrderBy(d => d.DateCreated).Take(2).ToList();

            IndexRecipe = _context.Recipes.Where(r => r.Status == "Approved").OrderBy(r => r.DateCreated).Take(2).ToList();
            
        }
    }
}
