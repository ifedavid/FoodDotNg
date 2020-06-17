using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FoodDotNg.Data
{
    public class FoodDotNgDbContext : IdentityDbContext<ApplicationUser>
    {
        public FoodDotNgDbContext(DbContextOptions<FoodDotNgDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<ArticleCategories>().HasData(
                new ArticleCategories
                {
                    AuthorId = "375587fa-0370-4d26-b72f-5acc5be09121",
                    Status = "Approved",
                    DateCreated = DateTime.UtcNow,
                    DateModified = DateTime.UtcNow,
                    Id = Guid.NewGuid(),
                    IsActive = true,
                    Name = "Interviews"
                },

                  new ArticleCategories
                {
                    AuthorId = "375587fa-0370-4d26-b72f-5acc5be09121",
                    Status = "Approved",
                    DateCreated = DateTime.UtcNow,
                    DateModified = DateTime.UtcNow,
                    Id = Guid.NewGuid(),
                    IsActive = true,
                    Name = "Food Life"
                },
                    new ArticleCategories
                {
                    AuthorId = "375587fa-0370-4d26-b72f-5acc5be09121",
                    Status = "Approved",
                    DateCreated = DateTime.UtcNow,
                    DateModified = DateTime.UtcNow,
                    Id = Guid.NewGuid(),
                    IsActive = true,
                    Name = "Latest News"
                },

                  new ArticleCategories
                {
                    AuthorId = "375587fa-0370-4d26-b72f-5acc5be09121",
                    Status = "Approved",
                    DateCreated = DateTime.UtcNow,
                    DateModified = DateTime.UtcNow,
                    Id = Guid.NewGuid(),
                    IsActive = true,
                    Name = "Cooking"
                },

                  new ArticleCategories
                {
                    AuthorId = "375587fa-0370-4d26-b72f-5acc5be09121",
                    Status = "Approved",
                    DateCreated = DateTime.UtcNow,
                    DateModified = DateTime.UtcNow,
                    Id = Guid.NewGuid(),
                    IsActive = true,
                    Name = "Health tips"
                }
            );
        }
        public DbSet<ArticleCategories> ArticleCategories {get; set;}
        public DbSet<Articles> Articles { get; set; }
        public DbSet<Recipes> Recipes { get; set; }
        public DbSet<Events> Events { get; set; }
    }
}
