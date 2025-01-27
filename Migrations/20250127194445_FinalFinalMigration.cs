using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ChickenSoup.Migrations
{
    /// <inheritdoc />
    public partial class FinalFinalMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Entries",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 27, 13, 44, 45, 118, DateTimeKind.Local).AddTicks(6860));

            migrationBuilder.UpdateData(
                table: "Entries",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 27, 13, 44, 45, 128, DateTimeKind.Local).AddTicks(9120));

            migrationBuilder.UpdateData(
                table: "Entries",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 27, 13, 44, 45, 128, DateTimeKind.Local).AddTicks(9130));

            migrationBuilder.UpdateData(
                table: "Entries",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 27, 13, 44, 45, 128, DateTimeKind.Local).AddTicks(9400));

            migrationBuilder.UpdateData(
                table: "Entries",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 27, 13, 44, 45, 128, DateTimeKind.Local).AddTicks(9420));

            migrationBuilder.UpdateData(
                table: "Entries",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 27, 13, 44, 45, 128, DateTimeKind.Local).AddTicks(9420));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Entries",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 27, 13, 29, 23, 385, DateTimeKind.Local).AddTicks(200));

            migrationBuilder.UpdateData(
                table: "Entries",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 27, 13, 29, 23, 395, DateTimeKind.Local).AddTicks(2100));

            migrationBuilder.UpdateData(
                table: "Entries",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 27, 13, 29, 23, 395, DateTimeKind.Local).AddTicks(2110));

            migrationBuilder.UpdateData(
                table: "Entries",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 27, 13, 29, 23, 395, DateTimeKind.Local).AddTicks(2380));

            migrationBuilder.UpdateData(
                table: "Entries",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 27, 13, 29, 23, 395, DateTimeKind.Local).AddTicks(2380));

            migrationBuilder.UpdateData(
                table: "Entries",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 27, 13, 29, 23, 395, DateTimeKind.Local).AddTicks(2390));
        }
    }
}
