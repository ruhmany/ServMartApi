using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Application_Layer.Migrations
{
    /// <inheritdoc />
    public partial class InitalCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2e7b8ccf-892c-4031-8c97-edd429f5d145");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5ce6f929-090a-43ba-b14d-f00b91a5ac9d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c8ff1f83-b099-4934-a518-322d91799cb0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f7ef1b77-6dbc-440a-aaba-ff742f99ec8c");

            migrationBuilder.EnsureSchema(
                name: "Shop");

            migrationBuilder.RenameTable(
                name: "Shop",
                newName: "Shop",
                newSchema: "Shop");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "Shop",
                table: "Shop",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                schema: "Shop",
                table: "Shop",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "47713b4b-ab5d-43ec-9ef5-60b55b187d9b", null, "Customer", "CUSTOMER" },
                    { "58f81450-49ad-4520-b763-03754a721741", null, "Vendor", "VENDOR" },
                    { "6811c58a-a38a-40ff-ad2a-09ba7119b380", null, "ServiceProvider", "SERVICEPROVIDER" },
                    { "857669e1-2905-4767-a209-6c6dd176f4b3", null, "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "47713b4b-ab5d-43ec-9ef5-60b55b187d9b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "58f81450-49ad-4520-b763-03754a721741");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6811c58a-a38a-40ff-ad2a-09ba7119b380");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "857669e1-2905-4767-a209-6c6dd176f4b3");

            migrationBuilder.RenameTable(
                name: "Shop",
                schema: "Shop",
                newName: "Shop");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Shop",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Shop",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2e7b8ccf-892c-4031-8c97-edd429f5d145", null, "Vendor", "VENDOR" },
                    { "5ce6f929-090a-43ba-b14d-f00b91a5ac9d", null, "Customer", "CUSTOMER" },
                    { "c8ff1f83-b099-4934-a518-322d91799cb0", null, "ServiceProvider", "SERVICEPROVIDER" },
                    { "f7ef1b77-6dbc-440a-aaba-ff742f99ec8c", null, "Admin", "ADMIN" }
                });
        }
    }
}
