using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodDotNg.Data.Migrations
{
    public partial class finishingtouches5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ArticleCategories",
                keyColumn: "Id",
                keyValue: new Guid("23d84d30-13d3-43c7-b832-b090f36e1966"));

            migrationBuilder.DeleteData(
                table: "ArticleCategories",
                keyColumn: "Id",
                keyValue: new Guid("7d135d08-f59f-4c04-b286-18edf9f38cdc"));

            migrationBuilder.DeleteData(
                table: "ArticleCategories",
                keyColumn: "Id",
                keyValue: new Guid("83d03600-3b1a-4942-9243-225a5f4806d7"));

            migrationBuilder.DeleteData(
                table: "ArticleCategories",
                keyColumn: "Id",
                keyValue: new Guid("96ff94e5-5c3d-4927-92f8-a0d143332fdd"));

            migrationBuilder.DeleteData(
                table: "ArticleCategories",
                keyColumn: "Id",
                keyValue: new Guid("c9d748c7-df88-485a-b2ac-a7c08f793e7a"));

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                    { new Guid("83d03600-3b1a-4942-9243-225a5f4806d7"), "375587fa-0370-4d26-b72f-5acc5be09121", new DateTime(2020, 6, 23, 2, 14, 29, 152, DateTimeKind.Utc).AddTicks(1509), new DateTime(2020, 6, 23, 2, 14, 29, 152, DateTimeKind.Utc).AddTicks(2122), null, "https://res.cloudinary.com/food-ng/image/upload/q_41/v1592766978/Static%20Images/Interview.jpg", true, "Interviews", "Approved" },
                    { new Guid("96ff94e5-5c3d-4927-92f8-a0d143332fdd"), "375587fa-0370-4d26-b72f-5acc5be09121", new DateTime(2020, 6, 23, 2, 14, 29, 152, DateTimeKind.Utc).AddTicks(4270), new DateTime(2020, 6, 23, 2, 14, 29, 152, DateTimeKind.Utc).AddTicks(4285), null, "https://res.cloudinary.com/food-ng/image/upload/q_43/v1592878239/Static%20Images/FoodCulture.jpg", true, "Food Culture", "Approved" },
                    { new Guid("c9d748c7-df88-485a-b2ac-a7c08f793e7a"), "375587fa-0370-4d26-b72f-5acc5be09121", new DateTime(2020, 6, 23, 2, 14, 29, 152, DateTimeKind.Utc).AddTicks(4337), new DateTime(2020, 6, 23, 2, 14, 29, 152, DateTimeKind.Utc).AddTicks(4338), null, "https://res.cloudinary.com/food-ng/image/upload/q_42/v1592767320/Static%20Images/LatestNews.jpg", true, "Latest News", "Approved" },
                    { new Guid("7d135d08-f59f-4c04-b286-18edf9f38cdc"), "375587fa-0370-4d26-b72f-5acc5be09121", new DateTime(2020, 6, 23, 2, 14, 29, 152, DateTimeKind.Utc).AddTicks(4341), new DateTime(2020, 6, 23, 2, 14, 29, 152, DateTimeKind.Utc).AddTicks(4342), null, "https://res.cloudinary.com/food-ng/image/upload/q_46/v1592761406/Static%20Images/Nigerian-Dishes.jpg", true, "Nigerian Dishes", "Approved" },
                    { new Guid("23d84d30-13d3-43c7-b832-b090f36e1966"), "375587fa-0370-4d26-b72f-5acc5be09121", new DateTime(2020, 6, 23, 2, 14, 29, 152, DateTimeKind.Utc).AddTicks(4345), new DateTime(2020, 6, 23, 2, 14, 29, 152, DateTimeKind.Utc).AddTicks(4346), null, "https://res.cloudinary.com/food-ng/image/upload/q_42/v1592767042/Static%20Images/Health%20and%20Tips.jpg", true, "Health tips", "Approved" }
                });
        }
    }
}
