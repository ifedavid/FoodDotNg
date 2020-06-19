using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodDotNg.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FoodDotNg.Pages
{
    public class EventsModel : PageModel
    {
        private readonly FoodDotNgDbContext _context;

        [BindProperty]
        public List<Events> EventPost { get; set; }
        public EventsModel(FoodDotNgDbContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
            EventPost = _context.Events.Where(e => e.Status == "Approved" && e.StartDate > DateTime.UtcNow).ToList();
        }
    }
}