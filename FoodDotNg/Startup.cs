using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using FoodDotNg.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace FoodDotNg
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<FoodDotNgDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));

            services.AddIdentity<ApplicationUser, IdentityRole>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<FoodDotNgDbContext>()
                .AddDefaultTokenProviders()
                .AddDefaultUI();
            services.AddRazorPages();

            services.AddAuthorization(options =>
            {
                options.AddPolicy("AllowedPeople",
                     policy => policy.RequireRole("Admin", "Writer"));
                options.AddPolicy("AdminOnly",
                    policy => policy.RequireRole("Admin"));
            });


            services.Configure<IdentityOptions>(options =>
            {
                options.Password.RequireDigit = false;
                options.Password.RequiredLength = 8;
                options.Password.RequiredUniqueChars = 0;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;

                options.User.RequireUniqueEmail = true;

     

            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IServiceProvider service)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });

            CreateUserRoles(service);
        }

        private void CreateUserRoles(IServiceProvider service)
        {
            var RoleManager = service.GetRequiredService<RoleManager<IdentityRole>>();
            var UserManager = service.GetRequiredService<UserManager<ApplicationUser>>();
            Task<IdentityResult> roleResult;
            string[] roleNames = { "Writer", "Admin", "RandomUser" };
            foreach (var Rolename in roleNames)
            {
                Task<bool> roleCheck =  RoleManager.RoleExistsAsync(Rolename);
                if (!roleCheck.Result)
                {


                    roleResult =  RoleManager.CreateAsync(new IdentityRole(Rolename));
                    roleResult.Wait();
                }
            }
            ApplicationUser user1 = new ApplicationUser
            {
                UserName = "JollyRobin",
                Email = "JollyRobin@gmail.com",

            };
            Task<IdentityResult> newUser = UserManager.CreateAsync(user1, "JollyRobin");
            newUser.Wait();
            Task<IdentityResult> newUserRole = UserManager.AddToRoleAsync(user1, "Admin");
            newUserRole.Wait();


        }

    }
}
