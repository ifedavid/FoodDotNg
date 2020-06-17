using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodDotNg.Data.Migrations
{
    public partial class EventOrganizerUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "EventPost",
                table: "Events",
                nullable: true);

            migrationBuilder.InsertData(
                table: "ArticleCategories",
                columns: new[] { "Id", "AuthorId", "DateCreated", "DateModified", "ImageUrl", "IsActive", "Name", "Status" },
                values: new object[,]
                {
                    { new Guid("99a133b7-5d28-4eff-a5d5-01ca935c088e"), "375587fa-0370-4d26-b72f-5acc5be09121", new DateTime(2020, 6, 17, 19, 15, 19, 131, DateTimeKind.Utc).AddTicks(451), new DateTime(2020, 6, 17, 19, 15, 19, 131, DateTimeKind.Utc).AddTicks(1391), null, true, "Interviews", "Approved" },
                    { new Guid("fe02ff70-f518-4860-a132-e8a053fe0656"), "375587fa-0370-4d26-b72f-5acc5be09121", new DateTime(2020, 6, 17, 19, 15, 19, 131, DateTimeKind.Utc).AddTicks(4967), new DateTime(2020, 6, 17, 19, 15, 19, 131, DateTimeKind.Utc).AddTicks(5001), null, true, "Food Life", "Approved" },
                    { new Guid("569c643a-7a0f-4244-849e-70c5c7134139"), "375587fa-0370-4d26-b72f-5acc5be09121", new DateTime(2020, 6, 17, 19, 15, 19, 131, DateTimeKind.Utc).AddTicks(5082), new DateTime(2020, 6, 17, 19, 15, 19, 131, DateTimeKind.Utc).AddTicks(5085), null, true, "Latest News", "Approved" },
                    { new Guid("a7dafb12-a5f7-47c6-94d3-e776c6631613"), "375587fa-0370-4d26-b72f-5acc5be09121", new DateTime(2020, 6, 17, 19, 15, 19, 131, DateTimeKind.Utc).AddTicks(5089), new DateTime(2020, 6, 17, 19, 15, 19, 131, DateTimeKind.Utc).AddTicks(5091), null, true, "Cooking", "Approved" },
                    { new Guid("a9ffb53e-7707-431c-85b4-2b110efbd5c9"), "375587fa-0370-4d26-b72f-5acc5be09121", new DateTime(2020, 6, 17, 19, 15, 19, 131, DateTimeKind.Utc).AddTicks(5095), new DateTime(2020, 6, 17, 19, 15, 19, 131, DateTimeKind.Utc).AddTicks(5097), null, true, "Health tips", "Approved" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ArticleCategories",
                keyColumn: "Id",
                keyValue: new Guid("569c643a-7a0f-4244-849e-70c5c7134139"));

            migrationBuilder.DeleteData(
                table: "ArticleCategories",
                keyColumn: "Id",
                keyValue: new Guid("99a133b7-5d28-4eff-a5d5-01ca935c088e"));

            migrationBuilder.DeleteData(
                table: "ArticleCategories",
                keyColumn: "Id",
                keyValue: new Guid("a7dafb12-a5f7-47c6-94d3-e776c6631613"));

            migrationBuilder.DeleteData(
                table: "ArticleCategories",
                keyColumn: "Id",
                keyValue: new Guid("a9ffb53e-7707-431c-85b4-2b110efbd5c9"));

            migrationBuilder.DeleteData(
                table: "ArticleCategories",
                keyColumn: "Id",
                keyValue: new Guid("fe02ff70-f518-4860-a132-e8a053fe0656"));

            migrationBuilder.DropColumn(
                name: "EventPost",
                table: "Events");

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
    }
}
