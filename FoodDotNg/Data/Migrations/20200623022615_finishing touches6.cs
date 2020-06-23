using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodDotNg.Data.Migrations
{
    public partial class finishingtouches6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articles_ArticleCategories_CategoryId",
                table: "Articles");

            migrationBuilder.DropIndex(
                name: "IX_Articles_CategoryId",
                table: "Articles");

            migrationBuilder.DeleteData(
                table: "ArticleCategories",
                keyColumn: "Id",
                keyValue: new Guid("3d7f7117-b62f-4409-9ed4-7d15c4bf81b2"));

            migrationBuilder.DeleteData(
                table: "ArticleCategories",
                keyColumn: "Id",
                keyValue: new Guid("74c6791d-8c99-486c-8b2e-e929a5a0aeee"));

            migrationBuilder.DeleteData(
                table: "ArticleCategories",
                keyColumn: "Id",
                keyValue: new Guid("77551627-7daa-413e-8372-b5bfed6f17b3"));

            migrationBuilder.DeleteData(
                table: "ArticleCategories",
                keyColumn: "Id",
                keyValue: new Guid("b0e13112-28eb-4e93-a093-dea9018325b0"));

            migrationBuilder.DeleteData(
                table: "ArticleCategories",
                keyColumn: "Id",
                keyValue: new Guid("dc89fa01-703d-459d-9ccb-6db5684354b3"));

            migrationBuilder.InsertData(
                table: "ArticleCategories",
                columns: new[] { "Id", "AuthorId", "DateCreated", "DateModified", "ImageSource", "ImageUrl", "IsActive", "Name", "Status" },
                values: new object[,]
                {
                    { new Guid("ff4021db-d40d-4510-acde-fbc307e7f3c5"), "375587fa-0370-4d26-b72f-5acc5be09121", new DateTime(2020, 6, 23, 2, 26, 15, 360, DateTimeKind.Utc).AddTicks(2946), new DateTime(2020, 6, 23, 2, 26, 15, 360, DateTimeKind.Utc).AddTicks(3495), null, "https://res.cloudinary.com/food-ng/image/upload/q_41/v1592766978/Static%20Images/Interview.jpg", true, "Interviews", "Approved" },
                    { new Guid("767861a8-0acc-472d-8da8-dd72c782bd51"), "375587fa-0370-4d26-b72f-5acc5be09121", new DateTime(2020, 6, 23, 2, 26, 15, 360, DateTimeKind.Utc).AddTicks(5667), new DateTime(2020, 6, 23, 2, 26, 15, 360, DateTimeKind.Utc).AddTicks(5680), null, "https://res.cloudinary.com/food-ng/image/upload/q_43/v1592878239/Static%20Images/FoodCulture.jpg", true, "Food Culture", "Approved" },
                    { new Guid("285bfbb2-aa81-458d-915e-06ebf2813595"), "375587fa-0370-4d26-b72f-5acc5be09121", new DateTime(2020, 6, 23, 2, 26, 15, 360, DateTimeKind.Utc).AddTicks(5723), new DateTime(2020, 6, 23, 2, 26, 15, 360, DateTimeKind.Utc).AddTicks(5724), null, "https://res.cloudinary.com/food-ng/image/upload/q_42/v1592767320/Static%20Images/LatestNews.jpg", true, "Latest News", "Approved" },
                    { new Guid("48a59982-9c23-45e2-b6a0-fc49223d46ad"), "375587fa-0370-4d26-b72f-5acc5be09121", new DateTime(2020, 6, 23, 2, 26, 15, 360, DateTimeKind.Utc).AddTicks(5727), new DateTime(2020, 6, 23, 2, 26, 15, 360, DateTimeKind.Utc).AddTicks(5728), null, "https://res.cloudinary.com/food-ng/image/upload/q_46/v1592761406/Static%20Images/Nigerian-Dishes.jpg", true, "Nigerian Dishes", "Approved" },
                    { new Guid("83ac75a5-47d9-4830-8262-93135e957789"), "375587fa-0370-4d26-b72f-5acc5be09121", new DateTime(2020, 6, 23, 2, 26, 15, 360, DateTimeKind.Utc).AddTicks(5730), new DateTime(2020, 6, 23, 2, 26, 15, 360, DateTimeKind.Utc).AddTicks(5731), null, "https://res.cloudinary.com/food-ng/image/upload/q_42/v1592767042/Static%20Images/Health%20and%20Tips.jpg", true, "Health tips", "Approved" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ArticleCategories",
                keyColumn: "Id",
                keyValue: new Guid("285bfbb2-aa81-458d-915e-06ebf2813595"));

            migrationBuilder.DeleteData(
                table: "ArticleCategories",
                keyColumn: "Id",
                keyValue: new Guid("48a59982-9c23-45e2-b6a0-fc49223d46ad"));

            migrationBuilder.DeleteData(
                table: "ArticleCategories",
                keyColumn: "Id",
                keyValue: new Guid("767861a8-0acc-472d-8da8-dd72c782bd51"));

            migrationBuilder.DeleteData(
                table: "ArticleCategories",
                keyColumn: "Id",
                keyValue: new Guid("83ac75a5-47d9-4830-8262-93135e957789"));

            migrationBuilder.DeleteData(
                table: "ArticleCategories",
                keyColumn: "Id",
                keyValue: new Guid("ff4021db-d40d-4510-acde-fbc307e7f3c5"));

            migrationBuilder.InsertData(
                table: "ArticleCategories",
                columns: new[] { "Id", "AuthorId", "DateCreated", "DateModified", "ImageSource", "ImageUrl", "IsActive", "Name", "Status" },
                values: new object[,]
                {
                    { new Guid("74c6791d-8c99-486c-8b2e-e929a5a0aeee"), "375587fa-0370-4d26-b72f-5acc5be09121", new DateTime(2020, 6, 23, 2, 23, 21, 402, DateTimeKind.Utc).AddTicks(95), new DateTime(2020, 6, 23, 2, 23, 21, 402, DateTimeKind.Utc).AddTicks(830), null, "https://res.cloudinary.com/food-ng/image/upload/q_41/v1592766978/Static%20Images/Interview.jpg", true, "Interviews", "Approved" },
                    { new Guid("b0e13112-28eb-4e93-a093-dea9018325b0"), "375587fa-0370-4d26-b72f-5acc5be09121", new DateTime(2020, 6, 23, 2, 23, 21, 402, DateTimeKind.Utc).AddTicks(3698), new DateTime(2020, 6, 23, 2, 23, 21, 402, DateTimeKind.Utc).AddTicks(3714), null, "https://res.cloudinary.com/food-ng/image/upload/q_43/v1592878239/Static%20Images/FoodCulture.jpg", true, "Food Culture", "Approved" },
                    { new Guid("dc89fa01-703d-459d-9ccb-6db5684354b3"), "375587fa-0370-4d26-b72f-5acc5be09121", new DateTime(2020, 6, 23, 2, 23, 21, 402, DateTimeKind.Utc).AddTicks(3777), new DateTime(2020, 6, 23, 2, 23, 21, 402, DateTimeKind.Utc).AddTicks(3778), null, "https://res.cloudinary.com/food-ng/image/upload/q_42/v1592767320/Static%20Images/LatestNews.jpg", true, "Latest News", "Approved" },
                    { new Guid("3d7f7117-b62f-4409-9ed4-7d15c4bf81b2"), "375587fa-0370-4d26-b72f-5acc5be09121", new DateTime(2020, 6, 23, 2, 23, 21, 402, DateTimeKind.Utc).AddTicks(3782), new DateTime(2020, 6, 23, 2, 23, 21, 402, DateTimeKind.Utc).AddTicks(3784), null, "https://res.cloudinary.com/food-ng/image/upload/q_46/v1592761406/Static%20Images/Nigerian-Dishes.jpg", true, "Nigerian Dishes", "Approved" },
                    { new Guid("77551627-7daa-413e-8372-b5bfed6f17b3"), "375587fa-0370-4d26-b72f-5acc5be09121", new DateTime(2020, 6, 23, 2, 23, 21, 402, DateTimeKind.Utc).AddTicks(3787), new DateTime(2020, 6, 23, 2, 23, 21, 402, DateTimeKind.Utc).AddTicks(3788), null, "https://res.cloudinary.com/food-ng/image/upload/q_42/v1592767042/Static%20Images/Health%20and%20Tips.jpg", true, "Health tips", "Approved" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Articles_CategoryId",
                table: "Articles",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_ArticleCategories_CategoryId",
                table: "Articles",
                column: "CategoryId",
                principalTable: "ArticleCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
