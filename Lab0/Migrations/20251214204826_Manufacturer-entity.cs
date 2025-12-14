using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lab0.Migrations
{
    /// <inheritdoc />
    public partial class Manufacturerentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_products_manufacturers_ManufacturerId",
                table: "products");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "manufacturers");

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Category", "Created" },
                values: new object[] { 2, new DateTime(2025, 12, 14, 21, 48, 25, 557, DateTimeKind.Local).AddTicks(1490) });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Category", "Created" },
                values: new object[] { 2, new DateTime(2025, 12, 14, 21, 48, 25, 570, DateTimeKind.Local).AddTicks(6670) });

            migrationBuilder.AddForeignKey(
                name: "FK_products_manufacturers_ManufacturerId",
                table: "products",
                column: "ManufacturerId",
                principalTable: "manufacturers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_products_manufacturers_ManufacturerId",
                table: "products");

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "manufacturers",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "manufacturers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Country",
                value: "Poland");

            migrationBuilder.UpdateData(
                table: "manufacturers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Country",
                value: "USA");

            migrationBuilder.UpdateData(
                table: "manufacturers",
                keyColumn: "Id",
                keyValue: 3,
                column: "Country",
                value: "USA");

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Category", "Created" },
                values: new object[] { 0, new DateTime(2025, 12, 14, 18, 35, 4, 250, DateTimeKind.Local).AddTicks(3910) });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Category", "Created" },
                values: new object[] { 0, new DateTime(2025, 12, 14, 18, 35, 4, 264, DateTimeKind.Local).AddTicks(1840) });

            migrationBuilder.AddForeignKey(
                name: "FK_products_manufacturers_ManufacturerId",
                table: "products",
                column: "ManufacturerId",
                principalTable: "manufacturers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
