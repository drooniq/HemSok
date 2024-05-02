using Microsoft.EntityFrameworkCore.Migrations;

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HemSok.Migrations
{
    /// <inheritdoc />
    public partial class identity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "293c0978-bc6d-4f78-ac24-3967d778c9be");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6038f205-a5a8-4a84-8347-2cab697c8c29");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d37a5652-6ed1-4018-b1fc-64d09fad28d4");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "15a8bdbc-6bda-457b-923b-698f40f59e36", null, "Agent", "AGENT" },
                    { "b70f2dd6-ffd1-4d28-89e9-49d70217cba5", null, "Admin", "ADMIN" },
                    { "dae8570d-ad82-4ac5-98ac-2e3aca5b6acc", null, "SuperAdmin", "SUPERADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "15a8bdbc-6bda-457b-923b-698f40f59e36");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b70f2dd6-ffd1-4d28-89e9-49d70217cba5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dae8570d-ad82-4ac5-98ac-2e3aca5b6acc");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "293c0978-bc6d-4f78-ac24-3967d778c9be", null, "Admin", "ADMIN" },
                    { "6038f205-a5a8-4a84-8347-2cab697c8c29", null, "SuperAdmin", "SUPERADMIN" },
                    { "d37a5652-6ed1-4018-b1fc-64d09fad28d4", null, "Agent", "AGENT" }
                });
        }
    }
}
