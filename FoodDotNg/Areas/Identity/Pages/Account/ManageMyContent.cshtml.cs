using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FoodDotNg.Areas.Identity.Pages.Account
{
    [Authorize(Policy = "AllowedPeople")]
    public class ManageMyContentModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
