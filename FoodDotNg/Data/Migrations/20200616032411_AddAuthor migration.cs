using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodDotNg.Data.Migrations
{
    public partial class AddAuthormigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ArticleCategories",
                keyColumn: "Id",
                keyValue: new Guid("2d4af3a0-aa5f-4c4b-9999-dbd3cb4a286b"));

            migrationBuilder.DeleteData(
                table: "ArticleCategories",
                keyColumn: "Id",
                keyValue: new Guid("b2f90511-8cc7-468b-97b2-f9f6cef2bfa7"));

            migrationBuilder.DeleteData(
                table: "ArticleCategories",
                keyColumn: "Id",
                keyValue: new Guid("d672f425-8d5c-4f25-9414-68c1242adcd1"));

            migrationBuilder.AddColumn<string>(
                name: "AuthorId",
                table: "Recipes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Recipes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AuthorId",
                table: "Events",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Events",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "AuthorId",
                table: "Articles",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Articles",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AuthorId",
                table: "ArticleCategories",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "ArticleCategories",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AuthorId",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "AuthorId",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "AuthorId",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "AuthorId",
                table: "ArticleCategories");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "ArticleCategories");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 128);

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
    }
}
