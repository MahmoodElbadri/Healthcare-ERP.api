using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Healthcare_ERP.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddingIdColumnForDoctroPatient : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AppUserId",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AppUserId",
                table: "Doctors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 21, 19, 15, 23, 814, DateTimeKind.Utc).AddTicks(1943));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 21, 19, 15, 23, 814, DateTimeKind.Utc).AddTicks(2845));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 21, 19, 15, 23, 814, DateTimeKind.Utc).AddTicks(2847));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 21, 19, 15, 23, 814, DateTimeKind.Utc).AddTicks(2848));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 21, 19, 15, 23, 814, DateTimeKind.Utc).AddTicks(2849));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 21, 19, 15, 23, 814, DateTimeKind.Utc).AddTicks(2854));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 21, 19, 15, 23, 814, DateTimeKind.Utc).AddTicks(2855));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 21, 19, 15, 23, 814, DateTimeKind.Utc).AddTicks(2856));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 21, 19, 15, 23, 814, DateTimeKind.Utc).AddTicks(2857));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 21, 19, 15, 23, 814, DateTimeKind.Utc).AddTicks(2859));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 21, 19, 15, 23, 814, DateTimeKind.Utc).AddTicks(2860));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 21, 19, 15, 23, 814, DateTimeKind.Utc).AddTicks(2860));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 21, 19, 15, 23, 814, DateTimeKind.Utc).AddTicks(2861));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 21, 19, 15, 23, 814, DateTimeKind.Utc).AddTicks(2862));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 21, 19, 15, 23, 814, DateTimeKind.Utc).AddTicks(2863));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 21, 19, 15, 23, 814, DateTimeKind.Utc).AddTicks(2864));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 21, 19, 15, 23, 814, DateTimeKind.Utc).AddTicks(2865));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 21, 19, 15, 23, 814, DateTimeKind.Utc).AddTicks(2866));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 21, 19, 15, 23, 814, DateTimeKind.Utc).AddTicks(2867));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 21, 19, 15, 23, 814, DateTimeKind.Utc).AddTicks(2868));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 21, 19, 15, 23, 814, DateTimeKind.Utc).AddTicks(2869));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 21, 19, 15, 23, 814, DateTimeKind.Utc).AddTicks(2870));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 21, 19, 15, 23, 814, DateTimeKind.Utc).AddTicks(2871));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 21, 19, 15, 23, 814, DateTimeKind.Utc).AddTicks(2872));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 21, 19, 15, 23, 814, DateTimeKind.Utc).AddTicks(2873));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 21, 19, 15, 23, 814, DateTimeKind.Utc).AddTicks(2873));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 21, 19, 15, 23, 814, DateTimeKind.Utc).AddTicks(2874));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 21, 19, 15, 23, 814, DateTimeKind.Utc).AddTicks(2875));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 21, 19, 15, 23, 814, DateTimeKind.Utc).AddTicks(2876));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 21, 19, 15, 23, 814, DateTimeKind.Utc).AddTicks(2876));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "Doctors");

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 20, 18, 35, 43, 45, DateTimeKind.Utc).AddTicks(1839));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 20, 18, 35, 43, 45, DateTimeKind.Utc).AddTicks(2814));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 20, 18, 35, 43, 45, DateTimeKind.Utc).AddTicks(2816));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 20, 18, 35, 43, 45, DateTimeKind.Utc).AddTicks(2817));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 20, 18, 35, 43, 45, DateTimeKind.Utc).AddTicks(2818));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 20, 18, 35, 43, 45, DateTimeKind.Utc).AddTicks(2826));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 20, 18, 35, 43, 45, DateTimeKind.Utc).AddTicks(2827));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 20, 18, 35, 43, 45, DateTimeKind.Utc).AddTicks(2828));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 20, 18, 35, 43, 45, DateTimeKind.Utc).AddTicks(2828));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 20, 18, 35, 43, 45, DateTimeKind.Utc).AddTicks(2831));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 20, 18, 35, 43, 45, DateTimeKind.Utc).AddTicks(2832));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 20, 18, 35, 43, 45, DateTimeKind.Utc).AddTicks(2833));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 20, 18, 35, 43, 45, DateTimeKind.Utc).AddTicks(2833));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 20, 18, 35, 43, 45, DateTimeKind.Utc).AddTicks(2834));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 20, 18, 35, 43, 45, DateTimeKind.Utc).AddTicks(2835));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 20, 18, 35, 43, 45, DateTimeKind.Utc).AddTicks(2836));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 20, 18, 35, 43, 45, DateTimeKind.Utc).AddTicks(2837));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 20, 18, 35, 43, 45, DateTimeKind.Utc).AddTicks(2839));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 20, 18, 35, 43, 45, DateTimeKind.Utc).AddTicks(2840));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 20, 18, 35, 43, 45, DateTimeKind.Utc).AddTicks(2841));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 20, 18, 35, 43, 45, DateTimeKind.Utc).AddTicks(2842));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 20, 18, 35, 43, 45, DateTimeKind.Utc).AddTicks(2843));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 20, 18, 35, 43, 45, DateTimeKind.Utc).AddTicks(2843));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 20, 18, 35, 43, 45, DateTimeKind.Utc).AddTicks(2844));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 20, 18, 35, 43, 45, DateTimeKind.Utc).AddTicks(2852));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 20, 18, 35, 43, 45, DateTimeKind.Utc).AddTicks(2853));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 20, 18, 35, 43, 45, DateTimeKind.Utc).AddTicks(2854));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 20, 18, 35, 43, 45, DateTimeKind.Utc).AddTicks(2854));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 20, 18, 35, 43, 45, DateTimeKind.Utc).AddTicks(2855));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 20, 18, 35, 43, 45, DateTimeKind.Utc).AddTicks(2856));
        }
    }
}
