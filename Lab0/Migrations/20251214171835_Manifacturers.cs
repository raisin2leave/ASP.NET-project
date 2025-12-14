using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Lab0.Migrations
{
    /// <inheritdoc />
    public partial class Manifacturers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ManufacturerId",
                table: "products",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "manufacturers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Country = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_manufacturers", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "manufacturers",
                columns: new[] { "Id", "Country", "Name" },
                values: new object[,]
                {
                    { 1, "Poland", "Default Manufacturer" },
                    { 2, "USA", "Dell" },
                    { 3, "USA", "HP" }
                });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Manufacturer", "ManufacturerId" },
                values: new object[] { new DateTime(2025, 12, 14, 18, 18, 34, 922, DateTimeKind.Local).AddTicks(8670), "", 2 });

            migrationBuilder.InsertData(
                table: "products",
                columns: new[] { "Id", "Category", "Created", "Description", "Manufacturer", "ManufacturerId", "Name", "Price", "production_date" },
                values: new object[] { 2, 0, new DateTime(2025, 12, 14, 18, 18, 34, 936, DateTimeKind.Local).AddTicks(6810), "Laser printer", "", 3, "Printer", 1200m, new DateTime(2022, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.CreateIndex(
                name: "IX_products_ManufacturerId",
                table: "products",
                column: "ManufacturerId");

            migrationBuilder.AddForeignKey(
                name: "FK_products_manufacturers_ManufacturerId",
                table: "products",
                column: "ManufacturerId",
                principalTable: "manufacturers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_products_manufacturers_ManufacturerId",
                table: "products");

            migrationBuilder.DropTable(
                name: "manufacturers");

            migrationBuilder.DropIndex(
                name: "IX_products_ManufacturerId",
                table: "products");

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "ManufacturerId",
                table: "products");

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Manufacturer" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dell" });
        }
    }
}
