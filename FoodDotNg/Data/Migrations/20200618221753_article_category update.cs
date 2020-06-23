using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodDotNg.Data.Migrations
{
    public partial class article_categoryupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articles_ArticleCategories_CategoryId",
                table: "Articles");

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

            migrationBuilder.AlterColumn<Guid>(
                name: "CategoryId",
                table: "Articles",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_ArticleCategories_CategoryId",
                table: "Articles",
                column: "CategoryId",
                principalTable: "ArticleCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articles_ArticleCategories_CategoryId",
                table: "Articles");

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

            migrationBuilder.AlterColumn<Guid>(
                name: "CategoryId",
                table: "Articles",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid));

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

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_ArticleCategories_CategoryId",
                table: "Articles",
                column: "CategoryId",
                principalTable: "ArticleCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
