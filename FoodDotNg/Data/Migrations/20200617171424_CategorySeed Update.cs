using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodDotNg.Data.Migrations
{
    public partial class CategorySeedUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ArticleCategories",
                columns: new[] { "Id", "AuthorId", "DateCreated", "DateModified", "ImageUrl", "IsActive", "Name", "Status" },
                values: new object[,]
                {
                    { new Guid("a006bf87-2b66-49e3-bc56-51faa2990ce5"), "375587fa-0370-4d26-b72f-5acc5be09121", new DateTime(2020, 6, 17, 17, 14, 23, 394, DateTimeKind.Utc).AddTicks(6528), new DateTime(2020, 6, 17, 17, 14, 23, 394, DateTimeKind.Utc).AddTicks(7782), null, true, "Interviews", "Approved" },
                    { new Guid("727aef6c-3cd2-4ee5-bcd3-1d7267a44123"), "375587fa-0370-4d26-b72f-5acc5be09121", new DateTime(2020, 6, 17, 17, 14, 23, 395, DateTimeKind.Utc).AddTicks(2085), new DateTime(2020, 6, 17, 17, 14, 23, 395, DateTimeKind.Utc).AddTicks(2121), null, true, "Food Life", "Approved" },
                    { new Guid("ccc74c85-75ae-4168-8761-8d8ed67f2479"), "375587fa-0370-4d26-b72f-5acc5be09121", new DateTime(2020, 6, 17, 17, 14, 23, 395, DateTimeKind.Utc).AddTicks(2217), new DateTime(2020, 6, 17, 17, 14, 23, 395, DateTimeKind.Utc).AddTicks(2219), null, true, "Latest News", "Approved" },
                    { new Guid("364e5143-8e9f-4a5c-b6dd-65ccc649a3aa"), "375587fa-0370-4d26-b72f-5acc5be09121", new DateTime(2020, 6, 17, 17, 14, 23, 395, DateTimeKind.Utc).AddTicks(2224), new DateTime(2020, 6, 17, 17, 14, 23, 395, DateTimeKind.Utc).AddTicks(2226), null, true, "Cooking", "Approved" },
                    { new Guid("600dfb08-0936-4356-887a-bb3cd3042641"), "375587fa-0370-4d26-b72f-5acc5be09121", new DateTime(2020, 6, 17, 17, 14, 23, 395, DateTimeKind.Utc).AddTicks(2230), new DateTime(2020, 6, 17, 17, 14, 23, 395, DateTimeKind.Utc).AddTicks(2232), null, true, "Health tips", "Approved" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ArticleCategories",
                keyColumn: "Id",
                keyValue: new Guid("364e5143-8e9f-4a5c-b6dd-65ccc649a3aa"));

            migrationBuilder.DeleteData(
                table: "ArticleCategories",
                keyColumn: "Id",
                keyValue: new Guid("600dfb08-0936-4356-887a-bb3cd3042641"));

            migrationBuilder.DeleteData(
                table: "ArticleCategories",
                keyColumn: "Id",
                keyValue: new Guid("727aef6c-3cd2-4ee5-bcd3-1d7267a44123"));

            migrationBuilder.DeleteData(
                table: "ArticleCategories",
                keyColumn: "Id",
                keyValue: new Guid("a006bf87-2b66-49e3-bc56-51faa2990ce5"));

            migrationBuilder.DeleteData(
                table: "ArticleCategories",
                keyColumn: "Id",
                keyValue: new Guid("ccc74c85-75ae-4168-8761-8d8ed67f2479"));
        }
    }
}
