using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lab0.Migrations
{
    /// <inheritdoc />
    public partial class manifacturerupdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Manufacturer",
                table: "products");

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2025, 12, 14, 18, 29, 22, 598, DateTimeKind.Local).AddTicks(2150));

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2025, 12, 14, 18, 29, 22, 609, DateTimeKind.Local).AddTicks(6590));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Manufacturer",
                table: "products",
                type: "TEXT",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Manufacturer" },
                values: new object[] { new DateTime(2025, 12, 14, 18, 18, 34, 922, DateTimeKind.Local).AddTicks(8670), "" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Manufacturer" },
                values: new object[] { new DateTime(2025, 12, 14, 18, 18, 34, 936, DateTimeKind.Local).AddTicks(6810), "" });
        }
    }
}
