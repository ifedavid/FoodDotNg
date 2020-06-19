using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDotNg.Data
{
    public class Articles : BaseModel
    {
        public string ArticlePost { get; set; }

        public int Likes { get; set; }

        public ArticleCategories Category { get; set; }

        public Guid CategoryId { get; set; }
    }
}
