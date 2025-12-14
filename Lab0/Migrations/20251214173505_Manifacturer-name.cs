using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lab0.Migrations
{
    /// <inheritdoc />
    public partial class Manifacturername : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2025, 12, 14, 18, 35, 4, 250, DateTimeKind.Local).AddTicks(3910));

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2025, 12, 14, 18, 35, 4, 264, DateTimeKind.Local).AddTicks(1840));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
