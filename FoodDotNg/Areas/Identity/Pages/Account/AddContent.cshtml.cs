using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodDotNg.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace FoodDotNg.Areas.Identity.Pages.Account
{
    [Authorize(Policy  = "AllowedPeople")]
    public class AddContentModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly FoodDotNgDbContext _context;

        [BindProperty]
        public ContentModel ContentModel { get; set; }
        public AddContentModel(UserManager<ApplicationUser> userManager, FoodDotNgDbContext context)
        {
            _userManager = userManager;
            _context = context;
        }
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAddContent(string type)
        {
            if (string.IsNullOrWhiteSpace(type))
            {
                return NotFound();
            }
            if(type == "Event")
            {
                var even_t = new Events
                {
                    StartDate = ContentModel.EventStart,
                    EndDate = ContentModel.EventEnd,
                    Name = ContentModel.BlogPostName,
                    Organizer = ContentModel.eventOrganizer,
                    EventPost = ContentModel.BlogPost,
                    Status = "Pending",
                    AuthorId = ContentModel.authorId,
                    DateCreated = DateTime.UtcNow,
                    DateModified = DateTime.UtcNow,
                };

               await _context.Events.AddAsync(even_t);
               await _context.SaveChangesAsync();
               return Page();
            }

            if (type == "Article")
            {
                var category = _context.ArticleCategories.Find(ContentModel.articleCategoryId);

                if(category == null)
                {
                    return NotFound();
                }
                var article = new Articles
                {

                    Name = ContentModel.BlogPostName,
                    ArticlePost = ContentModel.BlogPost,
                    Category = category,
                    Status = "Pending",
                    AuthorId = ContentModel.authorId,
                    DateCreated = DateTime.UtcNow,
                    DateModified = DateTime.UtcNow,
                };

                await _context.Articles.AddAsync(article);
                await _context.SaveChangesAsync();
                return Page();
            }

            if (type == "Recipe")
            {
                var recipe = new Recipes
                {
                    Name = ContentModel.BlogPostName,
                    RecipePost = ContentModel.BlogPost,
                    Steps = ContentModel.RecipeSteps,
                    Ingredients = ContentModel.RecipeIngredients,
                    Status = "Approved",
                    AuthorId = ContentModel.authorId,
                    DateCreated = DateTime.UtcNow,
                    DateModified = DateTime.UtcNow,
                };

                await _context.Recipes.AddAsync(recipe);
                await _context.SaveChangesAsync();
                return Page();
            }

            return Page();
        }
    }

    public class ContentModel
    {
        public Guid articleCategoryId { get; set; }
        public string eventOrganizer { get; set; }
        public string authorId { get; set; }
        public DateTime EventStart { get; set; }
        public DateTime EventEnd { get; set; }
        public string BlogPostName { get; set; }
        public string RecipeIngredients { get; set; }
        public string RecipeSteps { get; set; }
        public string BlogPost { get; set; }
    }
}
