using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Application_Layer.Migrations
{
    /// <inheritdoc />
    public partial class add : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                schema: "Service",
                table: "Service",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Duration",
                schema: "Service",
                table: "Service",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "date",
                schema: "Service",
                table: "Service",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "GETDATE()");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                schema: "Service",
                table: "Service");

            migrationBuilder.DropColumn(
                name: "Duration",
                schema: "Service",
                table: "Service");

            migrationBuilder.DropColumn(
                name: "date",
                schema: "Service",
                table: "Service");
        }
    }
}
