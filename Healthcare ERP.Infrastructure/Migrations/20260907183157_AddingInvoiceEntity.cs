using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Healthcare_ERP.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddingInvoiceEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Invoices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppointmentId = table.Column<int>(type: "int", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IssueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Invoices_Appointments_AppointmentId",
                        column: x => x.AppointmentId,
                        principalTable: "Appointments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_AppointmentId",
                table: "Invoices",
                column: "AppointmentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Invoices");

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 5, 9, 9, 30, 514, DateTimeKind.Utc).AddTicks(5846));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 5, 9, 9, 30, 514, DateTimeKind.Utc).AddTicks(7572));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 5, 9, 9, 30, 514, DateTimeKind.Utc).AddTicks(7577));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 5, 9, 9, 30, 514, DateTimeKind.Utc).AddTicks(7579));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 5, 9, 9, 30, 514, DateTimeKind.Utc).AddTicks(7581));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 5, 9, 9, 30, 514, DateTimeKind.Utc).AddTicks(7594));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 5, 9, 9, 30, 514, DateTimeKind.Utc).AddTicks(7595));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 5, 9, 9, 30, 514, DateTimeKind.Utc).AddTicks(7597));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 5, 9, 9, 30, 514, DateTimeKind.Utc).AddTicks(7598));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 5, 9, 9, 30, 514, DateTimeKind.Utc).AddTicks(7602));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 5, 9, 9, 30, 514, DateTimeKind.Utc).AddTicks(7603));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 5, 9, 9, 30, 514, DateTimeKind.Utc).AddTicks(7605));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 5, 9, 9, 30, 514, DateTimeKind.Utc).AddTicks(7606));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 5, 9, 9, 30, 514, DateTimeKind.Utc).AddTicks(7608));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 5, 9, 9, 30, 514, DateTimeKind.Utc).AddTicks(7609));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 5, 9, 9, 30, 514, DateTimeKind.Utc).AddTicks(7610));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 5, 9, 9, 30, 514, DateTimeKind.Utc).AddTicks(7612));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 5, 9, 9, 30, 514, DateTimeKind.Utc).AddTicks(7615));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 5, 9, 9, 30, 514, DateTimeKind.Utc).AddTicks(7617));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 5, 9, 9, 30, 514, DateTimeKind.Utc).AddTicks(7618));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 5, 9, 9, 30, 514, DateTimeKind.Utc).AddTicks(7620));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 5, 9, 9, 30, 514, DateTimeKind.Utc).AddTicks(7621));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 5, 9, 9, 30, 514, DateTimeKind.Utc).AddTicks(7623));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 5, 9, 9, 30, 514, DateTimeKind.Utc).AddTicks(7624));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 5, 9, 9, 30, 514, DateTimeKind.Utc).AddTicks(7626));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 5, 9, 9, 30, 514, DateTimeKind.Utc).AddTicks(7627));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 5, 9, 9, 30, 514, DateTimeKind.Utc).AddTicks(7628));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 5, 9, 9, 30, 514, DateTimeKind.Utc).AddTicks(7630));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 5, 9, 9, 30, 514, DateTimeKind.Utc).AddTicks(7631));

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 5, 9, 9, 30, 514, DateTimeKind.Utc).AddTicks(7632));
        }
    }
}
