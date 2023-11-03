using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Application_Layer.Migrations
{
    /// <inheritdoc />
    public partial class kh : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Duration",
                schema: "Service",
                table: "Service");

            migrationBuilder.DropColumn(
                name: "IsActive",
                schema: "Service",
                table: "Service");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "Service",
                table: "Service");

            migrationBuilder.DropColumn(
                name: "date",
                schema: "Service",
                table: "Service");

            migrationBuilder.RenameColumn(
                name: "Address",
                schema: "Service",
                table: "Service",
                newName: "FilePath");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FilePath",
                schema: "Service",
                table: "Service",
                newName: "Address");

            migrationBuilder.AddColumn<int>(
                name: "Duration",
                schema: "Service",
                table: "Service",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                schema: "Service",
                table: "Service",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "Service",
                table: "Service",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "date",
                schema: "Service",
                table: "Service",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "GETDATE()");
        }
    }
}
