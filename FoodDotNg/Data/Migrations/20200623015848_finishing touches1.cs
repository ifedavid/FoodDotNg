using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodDotNg.Data.Migrations
{
    public partial class finishingtouches1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "ArticleCategories",
                columns: new[] { "Id", "AuthorId", "DateCreated", "DateModified", "ImageSource", "ImageUrl", "IsActive", "Name", "Status" },
                values: new object[,]
                {
                    { new Guid("faaed1c5-6880-44f9-99ac-5e4323d33026"), "375587fa-0370-4d26-b72f-5acc5be09121", new DateTime(2020, 6, 23, 1, 58, 47, 862, DateTimeKind.Utc).AddTicks(7557), new DateTime(2020, 6, 23, 1, 58, 47, 862, DateTimeKind.Utc).AddTicks(8418), null, null, true, "Interviews", "Approved" },
                    { new Guid("51674646-15a8-4995-b506-e0a72befb200"), "375587fa-0370-4d26-b72f-5acc5be09121", new DateTime(2020, 6, 23, 1, 58, 47, 863, DateTimeKind.Utc).AddTicks(2259), new DateTime(2020, 6, 23, 1, 58, 47, 863, DateTimeKind.Utc).AddTicks(2285), null, null, true, "Food Culture", "Approved" },
                    { new Guid("2c5f9ace-d59f-47c1-a794-6b067f72aca7"), "375587fa-0370-4d26-b72f-5acc5be09121", new DateTime(2020, 6, 23, 1, 58, 47, 863, DateTimeKind.Utc).AddTicks(2404), new DateTime(2020, 6, 23, 1, 58, 47, 863, DateTimeKind.Utc).AddTicks(2407), null, null, true, "Latest News", "Approved" },
                    { new Guid("afba189d-6058-4d67-986a-4710c9047a78"), "375587fa-0370-4d26-b72f-5acc5be09121", new DateTime(2020, 6, 23, 1, 58, 47, 863, DateTimeKind.Utc).AddTicks(2433), new DateTime(2020, 6, 23, 1, 58, 47, 863, DateTimeKind.Utc).AddTicks(2436), null, null, true, "Nigerian Dishes", "Approved" },
                    { new Guid("2dfac122-827d-48f1-8287-44911450d027"), "375587fa-0370-4d26-b72f-5acc5be09121", new DateTime(2020, 6, 23, 1, 58, 47, 863, DateTimeKind.Utc).AddTicks(2441), new DateTime(2020, 6, 23, 1, 58, 47, 863, DateTimeKind.Utc).AddTicks(2442), null, null, true, "Health and tips", "Approved" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ArticleCategories",
                keyColumn: "Id",
                keyValue: new Guid("2c5f9ace-d59f-47c1-a794-6b067f72aca7"));

            migrationBuilder.DeleteData(
                table: "ArticleCategories",
                keyColumn: "Id",
                keyValue: new Guid("2dfac122-827d-48f1-8287-44911450d027"));

            migrationBuilder.DeleteData(
                table: "ArticleCategories",
                keyColumn: "Id",
                keyValue: new Guid("51674646-15a8-4995-b506-e0a72befb200"));

            migrationBuilder.DeleteData(
                table: "ArticleCategories",
                keyColumn: "Id",
                keyValue: new Guid("afba189d-6058-4d67-986a-4710c9047a78"));

            migrationBuilder.DeleteData(
                table: "ArticleCategories",
                keyColumn: "Id",
                keyValue: new Guid("faaed1c5-6880-44f9-99ac-5e4323d33026"));

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
    }
}
