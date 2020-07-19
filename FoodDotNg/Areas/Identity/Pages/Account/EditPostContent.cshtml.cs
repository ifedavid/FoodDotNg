using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodDotNg.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace FoodDotNg.Pages
{
    public class EditPostContentModel : PageModel
    {
        private readonly FoodDotNgDbContext _context;
        public Events EditEvent { get; set; }
        public Recipes EditRecipe { get; set; }
        public Articles EditArticle { get; set; }

        [BindProperty]
        public string PostEdit { get; set; }

        [BindProperty]
        public string PostTitle { get; set; }
        public EditPostContentModel(FoodDotNgDbContext context)
        {
            _context = context;
        }


        public async Task<IActionResult> OnGet(string postInfo)
        {
            if (postInfo == null || string.IsNullOrWhiteSpace(postInfo))
            {
                return NotFound();
            }
          string [] pageInfo = postInfo.Split(';');


            string pageType = pageInfo[0];
            ViewData["PageType"] = pageType;
            
            string Id = pageInfo[1];
            Guid postId = Guid.Parse(Id);


            if(pageType == "Article")
            {
               var blogPost = await _context.Articles.FindAsync(postId);
                EditArticle = blogPost;
                return Page();
            }

            if(pageType == "Event")
            {
                var blogPost = await _context.Events.FindAsync(postId);
                EditEvent = blogPost;
                return Page();
            }

            if (pageType == "Recipe")
            {
                var blogPost = await _context.Recipes.FindAsync(postId);
                EditRecipe = blogPost;
                return Page();
            }

            return NotFound();
        }


        public async Task<IActionResult> OnPostEdit(string postInfo)
        {
            string[] pageInfo = postInfo.Split(';');

            string pageType = pageInfo[0];
            string Id = pageInfo[1];
            Guid postId = Guid.Parse(Id);

            if(Id == null || string.IsNullOrWhiteSpace(Id))
            {
                return NotFound();
            }

            if(pageType == "Article")
            {
                var article = await _context.Articles.FindAsync(postId);

                article.ArticlePost = PostEdit;
                article.Name = PostTitle;

                _context.Entry(article).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                return RedirectToPage("ManageMyContent");
            }

            if (pageType == "Event")
            {
                var eventt = await _context.Events.FindAsync(postId);

                eventt.EventPost = PostEdit;
                eventt.Name = PostTitle;

                _context.Entry(eventt).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                return RedirectToPage("ManageMyContent");
            }

            if (pageType == "Recipe")
            {
                var recipe = await _context.Recipes.FindAsync(postId);

                recipe.RecipePost = PostEdit;
                recipe.Name = PostTitle;

                _context.Entry(recipe).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                return RedirectToPage("ManageMyContent");
            }

            return NotFound();
        }
    }
}