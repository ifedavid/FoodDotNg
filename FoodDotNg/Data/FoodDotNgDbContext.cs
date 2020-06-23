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
                    ImageUrl = "https://res.cloudinary.com/food-ng/image/upload/q_41/v1592766978/Static%20Images/Interview.jpg",
                    Status = "Approved",
                    DateCreated = DateTime.UtcNow,
                    DateModified = DateTime.UtcNow,
                    Id = Guid.Parse("ff4021db-d40d-4510-acde-fbc307e7f3c5"),
                    IsActive = true,
                    Name = "Interviews"
                },

                  new ArticleCategories
                  {
                      AuthorId = "375587fa-0370-4d26-b72f-5acc5be09121",
                      ImageUrl = "https://res.cloudinary.com/food-ng/image/upload/q_43/v1592878239/Static%20Images/FoodCulture.jpg",
                      Status = "Approved",
                      DateCreated = DateTime.UtcNow,
                      DateModified = DateTime.UtcNow,
                      Id = Guid.Parse("767861a8-0acc-472d-8da8-dd72c782bd51"),
                      IsActive = true,
                      Name = "Food Culture"
                  },
                    new ArticleCategories
                    {
                        AuthorId = "375587fa-0370-4d26-b72f-5acc5be09121",
                        ImageUrl = "https://res.cloudinary.com/food-ng/image/upload/q_42/v1592767320/Static%20Images/LatestNews.jpg",
                        Status = "Approved",
                        DateCreated = DateTime.UtcNow,
                        DateModified = DateTime.UtcNow,
                        Id = Guid.Parse("285bfbb2-aa81-458d-915e-06ebf2813595"),
                        IsActive = true,
                        Name = "Latest News"
                    },

                  new ArticleCategories
                  {
                      AuthorId = "375587fa-0370-4d26-b72f-5acc5be09121",
                      ImageUrl = "https://res.cloudinary.com/food-ng/image/upload/q_46/v1592761406/Static%20Images/Nigerian-Dishes.jpg",
                      Status = "Approved",
                      DateCreated = DateTime.UtcNow,
                      DateModified = DateTime.UtcNow,
                      Id = Guid.Parse("48a59982-9c23-45e2-b6a0-fc49223d46ad"),
                      IsActive = true,
                      Name = "Nigerian Dishes"
                  },

                  new ArticleCategories
                  {
                      AuthorId = "375587fa-0370-4d26-b72f-5acc5be09121",
                      ImageUrl = "https://res.cloudinary.com/food-ng/image/upload/q_42/v1592767042/Static%20Images/Health%20and%20Tips.jpg",
                      Status = "Approved",
                      DateCreated = DateTime.UtcNow,
                      DateModified = DateTime.UtcNow,
                      Id = Guid.Parse("83ac75a5-47d9-4830-8262-93135e957789"),
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
