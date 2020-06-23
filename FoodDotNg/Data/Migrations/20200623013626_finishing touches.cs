using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodDotNg.Data.Migrations
{
    public partial class finishingtouches : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ArticleCategories",
                keyColumn: "Id",
                keyValue: new Guid("513990ea-4138-4ae2-9dac-ae2dedb88028"));

            migrationBuilder.DeleteData(
                table: "ArticleCategories",
                keyColumn: "Id",
                keyValue: new Guid("6420e72a-4ea9-4398-9138-302e6d5211da"));

            migrationBuilder.DeleteData(
                table: "ArticleCategories",
                keyColumn: "Id",
                keyValue: new Guid("7a6f75ea-baf7-4249-b07b-3e7992bc9764"));

            migrationBuilder.DeleteData(
                table: "ArticleCategories",
                keyColumn: "Id",
                keyValue: new Guid("7afa2e84-c39c-4023-bcde-af2808285d56"));

            migrationBuilder.DeleteData(
                table: "ArticleCategories",
                keyColumn: "Id",
                keyValue: new Guid("ecf261c8-eb1d-4738-a10e-a45f5e22f2ef"));

            migrationBuilder.AddColumn<string>(
                name: "ImageSource",
                table: "Recipes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageSource",
                table: "Events",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageSource",
                table: "Articles",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageSource",
                table: "ArticleCategories",
                nullable: true);

            migrationBuilder.InsertData(
                table: "ArticleCategories",
                columns: new[] { "Id", "AuthorId", "DateCreated", "DateModified", "ImageSource", "ImageUrl", "IsActive", "Name", "Status" },
                values: new object[,]
                {
                    { new Guid("8b907b6d-3004-47a8-ad95-189bffe1a9e5"), "375587fa-0370-4d26-b72f-5acc5be09121", new DateTime(2020, 6, 23, 1, 36, 25, 755, DateTimeKind.Utc).AddTicks(6632), new DateTime(2020, 6, 23, 1, 36, 25, 755, DateTimeKind.Utc).AddTicks(7631), null, null, true, "Interviews", "Approved" },
                    { new Guid("2a867c2c-244d-4a14-832a-f35928254293"), "375587fa-0370-4d26-b72f-5acc5be09121", new DateTime(2020, 6, 23, 1, 36, 25, 756, DateTimeKind.Utc).AddTicks(1332), new DateTime(2020, 6, 23, 1, 36, 25, 756, DateTimeKind.Utc).AddTicks(1361), null, null, true, "Food Life", "Approved" },
                    { new Guid("d7364ef0-1e39-410d-a159-bbd18ee8c870"), "375587fa-0370-4d26-b72f-5acc5be09121", new DateTime(2020, 6, 23, 1, 36, 25, 756, DateTimeKind.Utc).AddTicks(1478), new DateTime(2020, 6, 23, 1, 36, 25, 756, DateTimeKind.Utc).AddTicks(1483), null, null, true, "Latest News", "Approved" },
                    { new Guid("589c5365-da5a-40ef-82b0-c77e10c64e56"), "375587fa-0370-4d26-b72f-5acc5be09121", new DateTime(2020, 6, 23, 1, 36, 25, 756, DateTimeKind.Utc).AddTicks(1490), new DateTime(2020, 6, 23, 1, 36, 25, 756, DateTimeKind.Utc).AddTicks(1491), null, null, true, "Cooking", "Approved" },
                    { new Guid("01248299-5fc5-4d16-8ee4-a7e9b3cda0fc"), "375587fa-0370-4d26-b72f-5acc5be09121", new DateTime(2020, 6, 23, 1, 36, 25, 756, DateTimeKind.Utc).AddTicks(1499), new DateTime(2020, 6, 23, 1, 36, 25, 756, DateTimeKind.Utc).AddTicks(1503), null, null, true, "Health and tips", "Approved" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ArticleCategories",
                keyColumn: "Id",
                keyValue: new Guid("01248299-5fc5-4d16-8ee4-a7e9b3cda0fc"));

            migrationBuilder.DeleteData(
                table: "ArticleCategories",
                keyColumn: "Id",
                keyValue: new Guid("2a867c2c-244d-4a14-832a-f35928254293"));

            migrationBuilder.DeleteData(
                table: "ArticleCategories",
                keyColumn: "Id",
                keyValue: new Guid("589c5365-da5a-40ef-82b0-c77e10c64e56"));

            migrationBuilder.DeleteData(
                table: "ArticleCategories",
                keyColumn: "Id",
                keyValue: new Guid("8b907b6d-3004-47a8-ad95-189bffe1a9e5"));

            migrationBuilder.DeleteData(
                table: "ArticleCategories",
                keyColumn: "Id",
                keyValue: new Guid("d7364ef0-1e39-410d-a159-bbd18ee8c870"));

            migrationBuilder.DropColumn(
                name: "ImageSource",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "ImageSource",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "ImageSource",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "ImageSource",
                table: "ArticleCategories");

            migrationBuilder.InsertData(
                table: "ArticleCategories",
                columns: new[] { "Id", "AuthorId", "DateCreated", "DateModified", "ImageUrl", "IsActive", "Name", "Status" },
                values: new object[,]
                {
                    { new Guid("7afa2e84-c39c-4023-bcde-af2808285d56"), "375587fa-0370-4d26-b72f-5acc5be09121", new DateTime(2020, 6, 18, 22, 17, 51, 406, DateTimeKind.Utc).AddTicks(310), new DateTime(2020, 6, 18, 22, 17, 51, 406, DateTimeKind.Utc).AddTicks(889), null, true, "Interviews", "Approved" },
                    { new Guid("7a6f75ea-baf7-4249-b07b-3e7992bc9764"), "375587fa-0370-4d26-b72f-5acc5be09121", new DateTime(2020, 6, 18, 22, 17, 51, 406, DateTimeKind.Utc).AddTicks(2945), new DateTime(2020, 6, 18, 22, 17, 51, 406, DateTimeKind.Utc).AddTicks(2957), null, true, "Food Life", "Approved" },
                    { new Guid("6420e72a-4ea9-4398-9138-302e6d5211da"), "375587fa-0370-4d26-b72f-5acc5be09121", new DateTime(2020, 6, 18, 22, 17, 51, 406, DateTimeKind.Utc).AddTicks(2997), new DateTime(2020, 6, 18, 22, 17, 51, 406, DateTimeKind.Utc).AddTicks(2998), null, true, "Latest News", "Approved" },
                    { new Guid("ecf261c8-eb1d-4738-a10e-a45f5e22f2ef"), "375587fa-0370-4d26-b72f-5acc5be09121", new DateTime(2020, 6, 18, 22, 17, 51, 406, DateTimeKind.Utc).AddTicks(3001), new DateTime(2020, 6, 18, 22, 17, 51, 406, DateTimeKind.Utc).AddTicks(3001), null, true, "Cooking", "Approved" },
                    { new Guid("513990ea-4138-4ae2-9dac-ae2dedb88028"), "375587fa-0370-4d26-b72f-5acc5be09121", new DateTime(2020, 6, 18, 22, 17, 51, 406, DateTimeKind.Utc).AddTicks(3018), new DateTime(2020, 6, 18, 22, 17, 51, 406, DateTimeKind.Utc).AddTicks(3019), null, true, "Health and tips", "Approved" }
                });
        }
    }
}
