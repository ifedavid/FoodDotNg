using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDotNg.Data
{
    public abstract class BaseModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateModified { get; set; }
        public bool IsActive { get; set; } = true;

        public string Status { get; set; } = "Pending";

        public string AuthorId { get; set; }

        [AllowNull]
        public string ImageUrl { get; set; }
    }
}
