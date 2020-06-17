using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodDotNg.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FoodDotNg.Areas.Identity.Pages.Account
{
    [Authorize(Policy = "AdminOnly")]
    public class AllUsersModel : PageModel
    {
        [BindProperty]
        public string Action { get; set; }
        [BindProperty]
        public string UserId { get; set; }

        private readonly UserManager<ApplicationUser> _userManager;
        private readonly FoodDotNgDbContext _context;

        public AllUsersModel(UserManager<ApplicationUser> userManager, FoodDotNgDbContext context)
        {
            _userManager = userManager;
            _context = context;
        }
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostEditUser()
        {
            var user = await _userManager.FindByIdAsync(UserId);

            if(Action == "MakeWriter")
            {
               await _userManager.RemoveFromRoleAsync(user, "RandomUser");
               await _userManager.AddToRoleAsync(user, "Writer");
            }

            if(Action == "RemoveAdmin")
            {
                await _userManager.RemoveFromRoleAsync(user, "Admin");
                await _userManager.AddToRoleAsync(user, "Writer");
            }

            if (Action == "RemoveWriter")
            {
                await _userManager.RemoveFromRoleAsync(user, "Writer");
                await _userManager.AddToRoleAsync(user, "RandomUser");
            }

            if (Action == "MakeAdmin")
            {
                await _userManager.RemoveFromRoleAsync(user, "Writer");
                await _userManager.AddToRoleAsync(user, "Admin");
            }
            return Page();
        }
    }
}
