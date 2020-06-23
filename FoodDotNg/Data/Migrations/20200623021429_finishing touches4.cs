using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodDotNg.Data.Migrations
{
    public partial class finishingtouches4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ArticleCategories",
                keyColumn: "Id",
                keyValue: new Guid("09279941-12a1-423c-8da1-ced4e6b5d81e"));

            migrationBuilder.DeleteData(
                table: "ArticleCategories",
                keyColumn: "Id",
                keyValue: new Guid("4c135b3c-aa1a-4c5d-ada6-5a07486024c0"));

            migrationBuilder.DeleteData(
                table: "ArticleCategories",
                keyColumn: "Id",
                keyValue: new Guid("5c0bd5cd-4ce1-4522-a297-f8d91965f146"));

            migrationBuilder.DeleteData(
                table: "ArticleCategories",
                keyColumn: "Id",
                keyValue: new Guid("8f5362c2-f6d5-4428-b70b-77302500c9bc"));

            migrationBuilder.DeleteData(
                table: "ArticleCategories",
                keyColumn: "Id",
                keyValue: new Guid("9df5e1f6-73d1-4515-bee2-694019e0426a"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new Guid("9df5e1f6-73d1-4515-bee2-694019e0426a"), "375587fa-0370-4d26-b72f-5acc5be09121", new DateTime(2020, 6, 23, 2, 7, 1, 216, DateTimeKind.Utc).AddTicks(9444), new DateTime(2020, 6, 23, 2, 7, 1, 217, DateTimeKind.Utc).AddTicks(261), null, "https://res.cloudinary.com/food-ng/image/upload/q_41/v1592766978/Static%20Images/Interview.jpg", true, "Interviews", "Approved" },
                    { new Guid("09279941-12a1-423c-8da1-ced4e6b5d81e"), "375587fa-0370-4d26-b72f-5acc5be09121", new DateTime(2020, 6, 23, 2, 7, 1, 217, DateTimeKind.Utc).AddTicks(3657), new DateTime(2020, 6, 23, 2, 7, 1, 217, DateTimeKind.Utc).AddTicks(3676), null, "https://res.cloudinary.com/food-ng/image/upload/q_43/v1592878239/Static%20Images/FoodCulture.jpg", true, "Food Culture", "Approved" },
                    { new Guid("5c0bd5cd-4ce1-4522-a297-f8d91965f146"), "375587fa-0370-4d26-b72f-5acc5be09121", new DateTime(2020, 6, 23, 2, 7, 1, 217, DateTimeKind.Utc).AddTicks(3743), new DateTime(2020, 6, 23, 2, 7, 1, 217, DateTimeKind.Utc).AddTicks(3745), null, "https://res.cloudinary.com/food-ng/image/upload/q_42/v1592767320/Static%20Images/LatestNews.jpg", true, "Latest News", "Approved" },
                    { new Guid("4c135b3c-aa1a-4c5d-ada6-5a07486024c0"), "375587fa-0370-4d26-b72f-5acc5be09121", new DateTime(2020, 6, 23, 2, 7, 1, 217, DateTimeKind.Utc).AddTicks(3748), new DateTime(2020, 6, 23, 2, 7, 1, 217, DateTimeKind.Utc).AddTicks(3750), null, "https://res.cloudinary.com/food-ng/image/upload/q_46/v1592761406/Static%20Images/Nigerian-Dishes.jpg", true, "Nigerian Dishes", "Approved" },
                    { new Guid("8f5362c2-f6d5-4428-b70b-77302500c9bc"), "375587fa-0370-4d26-b72f-5acc5be09121", new DateTime(2020, 6, 23, 2, 7, 1, 217, DateTimeKind.Utc).AddTicks(3753), new DateTime(2020, 6, 23, 2, 7, 1, 217, DateTimeKind.Utc).AddTicks(3754), null, "https://res.cloudinary.com/food-ng/image/upload/q_42/v1592767042/Static%20Images/Health%20and%20Tips.jpg", true, "Health tips", "Approved" }
                });
        }
    }
}
