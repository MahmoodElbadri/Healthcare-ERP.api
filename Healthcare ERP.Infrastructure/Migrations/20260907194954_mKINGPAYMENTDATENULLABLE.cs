using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Healthcare_ERP.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class mKINGPAYMENTDATENULLABLE : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                table: "Invoices",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 7, 19, 49, 52, 970, DateTimeKind.Utc).AddTicks(8766));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 7, 19, 49, 52, 971, DateTimeKind.Utc).AddTicks(686));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 7, 19, 49, 52, 971, DateTimeKind.Utc).AddTicks(691));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 7, 19, 49, 52, 971, DateTimeKind.Utc).AddTicks(693));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 7, 19, 49, 52, 971, DateTimeKind.Utc).AddTicks(695));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 7, 19, 49, 52, 971, DateTimeKind.Utc).AddTicks(715));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 7, 19, 49, 52, 971, DateTimeKind.Utc).AddTicks(719));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 7, 19, 49, 52, 971, DateTimeKind.Utc).AddTicks(721));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 7, 19, 49, 52, 971, DateTimeKind.Utc).AddTicks(722));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 7, 19, 49, 52, 971, DateTimeKind.Utc).AddTicks(726));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 7, 19, 49, 52, 971, DateTimeKind.Utc).AddTicks(728));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 7, 19, 49, 52, 971, DateTimeKind.Utc).AddTicks(729));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 7, 19, 49, 52, 971, DateTimeKind.Utc).AddTicks(733));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 7, 19, 49, 52, 971, DateTimeKind.Utc).AddTicks(734));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 7, 19, 49, 52, 971, DateTimeKind.Utc).AddTicks(735));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 7, 19, 49, 52, 971, DateTimeKind.Utc).AddTicks(737));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 7, 19, 49, 52, 971, DateTimeKind.Utc).AddTicks(738));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 7, 19, 49, 52, 971, DateTimeKind.Utc).AddTicks(741));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 7, 19, 49, 52, 971, DateTimeKind.Utc).AddTicks(743));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 7, 19, 49, 52, 971, DateTimeKind.Utc).AddTicks(746));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 7, 19, 49, 52, 971, DateTimeKind.Utc).AddTicks(748));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 7, 19, 49, 52, 971, DateTimeKind.Utc).AddTicks(749));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 7, 19, 49, 52, 971, DateTimeKind.Utc).AddTicks(750));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 7, 19, 49, 52, 971, DateTimeKind.Utc).AddTicks(752));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 7, 19, 49, 52, 971, DateTimeKind.Utc).AddTicks(753));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 7, 19, 49, 52, 971, DateTimeKind.Utc).AddTicks(755));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 7, 19, 49, 52, 971, DateTimeKind.Utc).AddTicks(756));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 7, 19, 49, 52, 971, DateTimeKind.Utc).AddTicks(757));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 7, 19, 49, 52, 971, DateTimeKind.Utc).AddTicks(761));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 7, 19, 49, 52, 971, DateTimeKind.Utc).AddTicks(762));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                table: "Invoices",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 7, 18, 31, 56, 400, DateTimeKind.Utc).AddTicks(36));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 7, 18, 31, 56, 400, DateTimeKind.Utc).AddTicks(1858));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 7, 18, 31, 56, 400, DateTimeKind.Utc).AddTicks(1863));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 7, 18, 31, 56, 400, DateTimeKind.Utc).AddTicks(1865));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 7, 18, 31, 56, 400, DateTimeKind.Utc).AddTicks(1866));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 7, 18, 31, 56, 400, DateTimeKind.Utc).AddTicks(1875));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 7, 18, 31, 56, 400, DateTimeKind.Utc).AddTicks(1876));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 7, 18, 31, 56, 400, DateTimeKind.Utc).AddTicks(1878));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 7, 18, 31, 56, 400, DateTimeKind.Utc).AddTicks(1879));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 7, 18, 31, 56, 400, DateTimeKind.Utc).AddTicks(1882));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 7, 18, 31, 56, 400, DateTimeKind.Utc).AddTicks(1884));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 7, 18, 31, 56, 400, DateTimeKind.Utc).AddTicks(1885));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 7, 18, 31, 56, 400, DateTimeKind.Utc).AddTicks(1886));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 7, 18, 31, 56, 400, DateTimeKind.Utc).AddTicks(1888));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 7, 18, 31, 56, 400, DateTimeKind.Utc).AddTicks(1889));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 7, 18, 31, 56, 400, DateTimeKind.Utc).AddTicks(1891));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 7, 18, 31, 56, 400, DateTimeKind.Utc).AddTicks(1892));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 7, 18, 31, 56, 400, DateTimeKind.Utc).AddTicks(1895));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 7, 18, 31, 56, 400, DateTimeKind.Utc).AddTicks(1897));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 7, 18, 31, 56, 400, DateTimeKind.Utc).AddTicks(1898));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 7, 18, 31, 56, 400, DateTimeKind.Utc).AddTicks(1899));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 7, 18, 31, 56, 400, DateTimeKind.Utc).AddTicks(1901));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 7, 18, 31, 56, 400, DateTimeKind.Utc).AddTicks(1902));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 7, 18, 31, 56, 400, DateTimeKind.Utc).AddTicks(1903));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 7, 18, 31, 56, 400, DateTimeKind.Utc).AddTicks(1904));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 7, 18, 31, 56, 400, DateTimeKind.Utc).AddTicks(1905));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 7, 18, 31, 56, 400, DateTimeKind.Utc).AddTicks(1907));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 7, 18, 31, 56, 400, DateTimeKind.Utc).AddTicks(1908));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 7, 18, 31, 56, 400, DateTimeKind.Utc).AddTicks(1909));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 7, 18, 31, 56, 400, DateTimeKind.Utc).AddTicks(1910));
        }
    }
}
