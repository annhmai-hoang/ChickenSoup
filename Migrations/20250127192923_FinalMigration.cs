using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ChickenSoup.Migrations
{
    /// <inheritdoc />
    public partial class FinalMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Entries",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 27, 12, 51, 12, 13, DateTimeKind.Local).AddTicks(9770));

            migrationBuilder.UpdateData(
                table: "Entries",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 27, 12, 51, 12, 23, DateTimeKind.Local).AddTicks(9820));

            migrationBuilder.UpdateData(
                table: "Entries",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 27, 12, 51, 12, 23, DateTimeKind.Local).AddTicks(9830));

            migrationBuilder.UpdateData(
                table: "Entries",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 27, 12, 51, 12, 24, DateTimeKind.Local).AddTicks(230));

            migrationBuilder.UpdateData(
                table: "Entries",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 27, 12, 51, 12, 24, DateTimeKind.Local).AddTicks(230));

            migrationBuilder.UpdateData(
                table: "Entries",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 27, 12, 51, 12, 24, DateTimeKind.Local).AddTicks(230));
        }
    }
}
