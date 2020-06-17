using FoodDotNg.Data;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDotNg.ViewModels
{
    public class CreateContentViewModel
    {
        public string Name { get; set; }

        public string BlogPost { get; set; }
        public string Steps { get; set; }
        public string Ingredients { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public IdentityUser Author { get; set; }

        public ArticleCategories ArticleCategory { get; set; }

        public string Status { get; set; }
    }
}
