using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodDotNg.Data.Migrations
{
    public partial class editfeature : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ArticleCategories",
                keyColumn: "Id",
                keyValue: new Guid("285bfbb2-aa81-458d-915e-06ebf2813595"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 7, 8, 3, 27, 22, 241, DateTimeKind.Utc).AddTicks(4669), new DateTime(2020, 7, 8, 3, 27, 22, 241, DateTimeKind.Utc).AddTicks(4670) });

            migrationBuilder.UpdateData(
                table: "ArticleCategories",
                keyColumn: "Id",
                keyValue: new Guid("48a59982-9c23-45e2-b6a0-fc49223d46ad"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 7, 8, 3, 27, 22, 241, DateTimeKind.Utc).AddTicks(4681), new DateTime(2020, 7, 8, 3, 27, 22, 241, DateTimeKind.Utc).AddTicks(4683) });

            migrationBuilder.UpdateData(
                table: "ArticleCategories",
                keyColumn: "Id",
                keyValue: new Guid("767861a8-0acc-472d-8da8-dd72c782bd51"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 7, 8, 3, 27, 22, 241, DateTimeKind.Utc).AddTicks(4540), new DateTime(2020, 7, 8, 3, 27, 22, 241, DateTimeKind.Utc).AddTicks(4562) });

            migrationBuilder.UpdateData(
                table: "ArticleCategories",
                keyColumn: "Id",
                keyValue: new Guid("83ac75a5-47d9-4830-8262-93135e957789"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 7, 8, 3, 27, 22, 241, DateTimeKind.Utc).AddTicks(4691), new DateTime(2020, 7, 8, 3, 27, 22, 241, DateTimeKind.Utc).AddTicks(4692) });

            migrationBuilder.UpdateData(
                table: "ArticleCategories",
                keyColumn: "Id",
                keyValue: new Guid("ff4021db-d40d-4510-acde-fbc307e7f3c5"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 7, 8, 3, 27, 22, 241, DateTimeKind.Utc).AddTicks(218), new DateTime(2020, 7, 8, 3, 27, 22, 241, DateTimeKind.Utc).AddTicks(1118) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ArticleCategories",
                keyColumn: "Id",
                keyValue: new Guid("285bfbb2-aa81-458d-915e-06ebf2813595"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 6, 24, 19, 20, 49, 118, DateTimeKind.Utc).AddTicks(6992), new DateTime(2020, 6, 24, 19, 20, 49, 118, DateTimeKind.Utc).AddTicks(6994) });

            migrationBuilder.UpdateData(
                table: "ArticleCategories",
                keyColumn: "Id",
                keyValue: new Guid("48a59982-9c23-45e2-b6a0-fc49223d46ad"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 6, 24, 19, 20, 49, 118, DateTimeKind.Utc).AddTicks(7000), new DateTime(2020, 6, 24, 19, 20, 49, 118, DateTimeKind.Utc).AddTicks(7001) });

            migrationBuilder.UpdateData(
                table: "ArticleCategories",
                keyColumn: "Id",
                keyValue: new Guid("767861a8-0acc-472d-8da8-dd72c782bd51"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 6, 24, 19, 20, 49, 118, DateTimeKind.Utc).AddTicks(6929), new DateTime(2020, 6, 24, 19, 20, 49, 118, DateTimeKind.Utc).AddTicks(6942) });

            migrationBuilder.UpdateData(
                table: "ArticleCategories",
                keyColumn: "Id",
                keyValue: new Guid("83ac75a5-47d9-4830-8262-93135e957789"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 6, 24, 19, 20, 49, 118, DateTimeKind.Utc).AddTicks(7005), new DateTime(2020, 6, 24, 19, 20, 49, 118, DateTimeKind.Utc).AddTicks(7006) });

            migrationBuilder.UpdateData(
                table: "ArticleCategories",
                keyColumn: "Id",
                keyValue: new Guid("ff4021db-d40d-4510-acde-fbc307e7f3c5"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 6, 24, 19, 20, 49, 118, DateTimeKind.Utc).AddTicks(5041), new DateTime(2020, 6, 24, 19, 20, 49, 118, DateTimeKind.Utc).AddTicks(5404) });
        }
    }
}
