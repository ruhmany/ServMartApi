using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Application_Layer.Migrations
{
    /// <inheritdoc />
    public partial class UpdateProductAsUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Shop_ShopID",
                schema: "Product",
                table: "Product");

            migrationBuilder.AlterColumn<Guid>(
                name: "ShopID",
                schema: "Product",
                table: "Product",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<string>(
                name: "ProviderId",
                schema: "Product",
                table: "Product",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Product_ProviderId",
                schema: "Product",
                table: "Product",
                column: "ProviderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_AspNetUsers_ProviderId",
                schema: "Product",
                table: "Product",
                column: "ProviderId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Shop_ShopID",
                schema: "Product",
                table: "Product",
                column: "ShopID",
                principalSchema: "Shop",
                principalTable: "Shop",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_AspNetUsers_ProviderId",
                schema: "Product",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Shop_ShopID",
                schema: "Product",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Product_ProviderId",
                schema: "Product",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "ProviderId",
                schema: "Product",
                table: "Product");

            migrationBuilder.AlterColumn<Guid>(
                name: "ShopID",
                schema: "Product",
                table: "Product",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Shop_ShopID",
                schema: "Product",
                table: "Product",
                column: "ShopID",
                principalSchema: "Shop",
                principalTable: "Shop",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
