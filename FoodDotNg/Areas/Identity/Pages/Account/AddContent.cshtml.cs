using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using FoodDotNg.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Microsoft.AspNetCore.Hosting;

namespace FoodDotNg.Areas.Identity.Pages.Account
{
    [Authorize(Policy  = "AllowedPeople")]
    public class AddContentModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IWebHostEnvironment _hostEnvironment;
        private readonly FoodDotNgDbContext _context;

        public AddContentModel(UserManager<ApplicationUser> userManager, FoodDotNgDbContext context, IWebHostEnvironment hostEnvironment)
        {
            _userManager = userManager;
            _context = context;
            _hostEnvironment = hostEnvironment;
        }
        public void OnGet()
        {
        }

        public async Task<string> UploadImage(ContentModel ContentModel)
        {
            var myAccount = new CloudinaryDotNet.Account { ApiKey = "917462976781737", ApiSecret = "N6Jod9FI_27eYX7pZNLfcs7Qg-c", Cloud = "food-ng" };
            Cloudinary _cloudinary = new Cloudinary(myAccount);

            string wwwRootPath = _hostEnvironment.WebRootPath;
            string fileName = Path.GetFileNameWithoutExtension(ContentModel.ImageFile.FileName);
            string extension = Path.GetExtension(ContentModel.ImageFile.FileName);
            fileName = fileName + DateTime.UtcNow.ToString("yymmssfff") + extension;
            string path = Path.Combine(wwwRootPath + "/images/", fileName);

            using(var filestream = new FileStream(path, FileMode.Create))
            {
                await ContentModel.ImageFile.CopyToAsync(filestream);
            }
            var uploadParameters = new ImageUploadParams()
            {
                File = new FileDescription(path),
               
            };


            var uploadResult = await _cloudinary.UploadAsync(uploadParameters);

            var imageUrl = _cloudinary.Api.UrlImgUp.Transform(new Transformation().Quality(40).FetchFormat("auto")).BuildUrl(uploadResult.PublicId);

            if (System.IO.File.Exists(path)) System.IO.File.Delete(path);

            return imageUrl;

        }

        public async Task<IActionResult> OnPostAddContent(string type, ContentModel ContentModel)
        {
            var imageUrl = UploadImage(ContentModel);
            string imageUrll = imageUrl.Result;

            if (string.IsNullOrWhiteSpace(type))
            {
                return NotFound();
            }
            if(type == "Event")
            {
                var even_t = new Events
                {
                    StartDate = ContentModel.EventStart,
                    EndDate = ContentModel.EventEnd,
                    Name = ContentModel.BlogPostName,
                    Organizer = ContentModel.eventOrganizer,
                    EventPost = ContentModel.BlogPost,
                    Status = "Pending",
                    AuthorId = ContentModel.authorId,
                    DateCreated = DateTime.UtcNow,
                    DateModified = DateTime.UtcNow,
                    ImageUrl = imageUrll,
                    ImageSource = ContentModel.ImageSource
                };

               await _context.Events.AddAsync(even_t);
               await _context.SaveChangesAsync();
               return RedirectToPage("ManageMyContent");
            }

            if (type == "Article")
            {
                
                var category = _context.ArticleCategories.Find(ContentModel.articleCategoryId);

                if(category == null)
                {
                    return NotFound();
                }
                var article = new Articles
                {

                    Name = ContentModel.BlogPostName,
                    ArticlePost = ContentModel.BlogPost,
                    CategoryId = ContentModel.articleCategoryId,
                    Status = "Pending",
                    AuthorId = ContentModel.authorId,
                    DateCreated = DateTime.UtcNow,
                    DateModified = DateTime.UtcNow,
                    ImageUrl = imageUrll,
                    ImageSource = ContentModel.ImageSource

                };

                await _context.Articles.AddAsync(article);
                await _context.SaveChangesAsync();
                return RedirectToPage("ManageMyContent");
            }

            if (type == "Recipe")
            {
                var recipe = new Recipes
                {
                    Name = ContentModel.BlogPostName,
                    RecipePost = ContentModel.BlogPost,
                    Steps = ContentModel.RecipeSteps,
                    Ingredients = ContentModel.RecipeIngredients,
                    Status = "Pending",
                    AuthorId = ContentModel.authorId,
                    DateCreated = DateTime.UtcNow,
                    DateModified = DateTime.UtcNow,
                    ImageUrl = imageUrll,
                    ImageSource = ContentModel.ImageSource
                };

                await _context.Recipes.AddAsync(recipe);
                await _context.SaveChangesAsync();
                return RedirectToPage("ManageMyContent");
            }

            return Page();
        }
    }

    public class ContentModel
    {
        public Guid articleCategoryId { get; set; }
        public string eventOrganizer { get; set; }
        public string authorId { get; set; }
        public DateTime EventStart { get; set; }
        public DateTime EventEnd { get; set; }
        public string BlogPostName { get; set; }
        public string RecipeIngredients { get; set; }
        public string RecipeSteps { get; set; }
        public string BlogPost { get; set; }
        public IFormFile ImageFile { get; set; }
        public string ImageSource { get; set; }
    }
}
