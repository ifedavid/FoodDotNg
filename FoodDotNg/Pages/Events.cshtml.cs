using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodDotNg.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ReflectionIT.Mvc.Paging;

namespace FoodDotNg.Pages
{
    public class EventsModel : PageModel
    {
        private readonly FoodDotNgDbContext _context;


        public int CurrentPage { get; set; } = 1;

        public int Count { get; set; }

        public int PageSize { get; set; } = 3;

        public int TotalPages => (int)Math.Ceiling(decimal.Divide(Count, PageSize));

        public bool EnablePrevious => CurrentPage > 1;

        public bool EnableNext => CurrentPage < TotalPages;

        [BindProperty]
        public List<Events> EventPost { get; set; }
        public EventsModel(FoodDotNgDbContext context)
        {
            _context = context;
        }
        public void OnGet(int currentPage)
        {

            CurrentPage = currentPage == 0 ? 1 : currentPage;

            Count = _context.Events.Count();

            if (CurrentPage > TotalPages)
                CurrentPage = TotalPages;

            EventPost = _context.Events.Where(e=> e.Status == "Approved" && e.StartDate >= DateTime.UtcNow)
                .Skip((CurrentPage - 1) * PageSize)
                .Take(PageSize)
                .OrderBy(e => e.DateCreated)
                .ToList();

        }
    }
}