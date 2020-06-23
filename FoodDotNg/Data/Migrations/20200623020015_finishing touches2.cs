using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodDotNg.Data.Migrations
{
    public partial class finishingtouches2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
