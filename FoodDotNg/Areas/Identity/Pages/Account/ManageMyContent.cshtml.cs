using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodDotNg.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FoodDotNg.Areas.Identity.Pages.Account
{
    [Authorize(Policy = "AllowedPeople")]
    public class ManageMyContentModel : PageModel
    {
        private readonly FoodDotNgDbContext _context;
        public ManageMyContentModel(FoodDotNgDbContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostDelete(string type)
        {
            string[] data = type.Split(';').ToArray();
            type = data[0];
            Guid Id = Guid.Empty;
            string id = data[1];

            try
            {
                Id = Guid.Parse(id);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception:" + e);
            }


            if (type == "Article")
            {
               var article = await _context.Articles.FindAsync(Id);

                if(article == null)
                {
                    return NotFound();
                }

                article.Status = "Deleted";
                _context.Entry(article).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                await _context.SaveChangesAsync();
                return Page();
            }


            if (type == "Event")
            {
                var eventt = await _context.Events.FindAsync(Id);

                if (eventt == null)
                {
                    return NotFound();
                }
                eventt.Status = "Deleted";
                _context.Entry(eventt).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                await _context.SaveChangesAsync();
                return Page();
            }


            if (type == "Recipe")
            {
                var recipe = await _context.Recipes.FindAsync(Id);
                if (recipe == null)
                {
                    return NotFound();
                }
                recipe.Status = "Deleted";
                _context.Entry(recipe).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                await _context.SaveChangesAsync();
                return Page();
            }

            return NotFound();
        }

        public async Task<IActionResult> OnPostApprove(string type)
        {
            string[] data = type.Split(';').ToArray();
            type = data[0];
            Guid Id = Guid.Empty;
            string id = data[1];

            try
            {
                Id = Guid.Parse(id);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception:" + e);
            }


            if (type == "Article")
            {
                var article = await _context.Articles.FindAsync(Id);

                if (article == null)
                {
                    return NotFound();
                }

                article.Status = "Approved";
                _context.Entry(article).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                await _context.SaveChangesAsync();
                return Page();
            }


            if (type == "Event")
            {
                var eventt = await _context.Events.FindAsync(Id);

                if (eventt == null)
                {
                    return NotFound();
                }
                eventt.Status = "Approved";
                _context.Entry(eventt).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                await _context.SaveChangesAsync();
                return Page();
            }


            if (type == "Recipe")
            {
                var recipe = await _context.Recipes.FindAsync(Id);
                if (recipe == null)
                {
                    return NotFound();
                }
                recipe.Status = "Approved";
                _context.Entry(recipe).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                await _context.SaveChangesAsync();
                return Page();
            }

            return NotFound();
        }
    }
}
