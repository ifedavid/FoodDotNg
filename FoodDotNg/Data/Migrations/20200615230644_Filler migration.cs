using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodDotNg.Data.Migrations
{
    public partial class Fillermigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ArticleCategories",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Articles",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    ArticlePost = table.Column<string>(nullable: true),
                    Likes = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    Organizer = table.Column<string>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Recipes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    Ingredients = table.Column<string>(nullable: true),
                    Steps = table.Column<string>(nullable: true),
                    RecipePost = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipes", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "ArticleCategories",
                columns: new[] { "Id", "DateCreated", "DateModified", "IsActive", "Name" },
                values: new object[] { new Guid("2d4af3a0-aa5f-4c4b-9999-dbd3cb4a286b"), new DateTime(2020, 6, 15, 23, 6, 41, 783, DateTimeKind.Utc).AddTicks(2921), new DateTime(2020, 6, 15, 23, 6, 41, 783, DateTimeKind.Utc).AddTicks(4064), true, "Recipes" });

            migrationBuilder.InsertData(
                table: "ArticleCategories",
                columns: new[] { "Id", "DateCreated", "DateModified", "IsActive", "Name" },
                values: new object[] { new Guid("d672f425-8d5c-4f25-9414-68c1242adcd1"), new DateTime(2020, 6, 15, 23, 6, 41, 783, DateTimeKind.Utc).AddTicks(5262), new DateTime(2020, 6, 15, 23, 6, 41, 783, DateTimeKind.Utc).AddTicks(5288), true, "Interviews" });

            migrationBuilder.InsertData(
                table: "ArticleCategories",
                columns: new[] { "Id", "DateCreated", "DateModified", "IsActive", "Name" },
                values: new object[] { new Guid("b2f90511-8cc7-468b-97b2-f9f6cef2bfa7"), new DateTime(2020, 6, 15, 23, 6, 41, 783, DateTimeKind.Utc).AddTicks(5319), new DateTime(2020, 6, 15, 23, 6, 41, 783, DateTimeKind.Utc).AddTicks(5321), true, "Food News" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArticleCategories");

            migrationBuilder.DropTable(
                name: "Articles");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "Recipes");
        }
    }
}
