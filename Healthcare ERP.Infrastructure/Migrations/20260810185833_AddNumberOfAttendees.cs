using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Healthcare_ERP.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddNumberOfAttendees : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumberOfAttendees",
                table: "Appointments");

            migrationBuilder.AddColumn<int>(
                name: "NumberOfAttendees",
                table: "Doctors",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumberOfAttendees",
                table: "Doctors");

            migrationBuilder.AddColumn<int>(
                name: "NumberOfAttendees",
                table: "Appointments",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
