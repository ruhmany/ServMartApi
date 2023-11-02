using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Application_Layer.Migrations
{
    /// <inheritdoc />
    public partial class UpdationgRequestTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDirect",
                schema: "Service",
                table: "RequestOffer");

            migrationBuilder.AddColumn<string>(
                name: "Details",
                schema: "Service",
                table: "RequestOffer",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                schema: "Service",
                table: "RequestOffer",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<decimal>(
                name: "ExpectSalary",
                schema: "Service",
                table: "RequestOffer",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                schema: "Service",
                table: "RequestOffer",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsDirect",
                schema: "Service",
                table: "Request",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                schema: "Service",
                table: "Request",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "AspNetUsers",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Details",
                schema: "Service",
                table: "RequestOffer");

            migrationBuilder.DropColumn(
                name: "EndDate",
                schema: "Service",
                table: "RequestOffer");

            migrationBuilder.DropColumn(
                name: "ExpectSalary",
                schema: "Service",
                table: "RequestOffer");

            migrationBuilder.DropColumn(
                name: "StartDate",
                schema: "Service",
                table: "RequestOffer");

            migrationBuilder.DropColumn(
                name: "IsDirect",
                schema: "Service",
                table: "Request");

            migrationBuilder.DropColumn(
                name: "Title",
                schema: "Service",
                table: "Request");

            migrationBuilder.AddColumn<bool>(
                name: "IsDirect",
                schema: "Service",
                table: "RequestOffer",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "AspNetUsers",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250,
                oldNullable: true);
        }
    }
}
