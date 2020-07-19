using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodDotNg.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FoodDotNg.Pages
{
    public class EventPostModel : PageModel
    {
        private readonly FoodDotNgDbContext _context;

        [BindProperty]
        public Guid PostId { get; set; }
        public Events BlogPost { get; set; }
        public List<Events> Events { get; set; }
        public EventPostModel(FoodDotNgDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> OnGet(Guid postId)
        {
            Events = _context.Events.Where(e => e.Status == "Approved").ToList();
            BlogPost = await _context.Events.FindAsync(postId);
            if (BlogPost == null)
            {
                return NotFound();
            }
            Events.Remove(BlogPost);

            return Page();

        }
    }
}