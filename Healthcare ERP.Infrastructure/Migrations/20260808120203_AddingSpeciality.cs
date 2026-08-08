using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Healthcare_ERP.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddingSpeciality : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Specialities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specialities", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Specialities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Cardiology" },
                    { 2, "Dermatology" },
                    { 3, "Neurology" },
                    { 4, "Pediatrics" },
                    { 5, "Orthopedics" },
                    { 6, "Ophthalmology" },
                    { 7, "Dentistry" },
                    { 8, "Gynecology and Obstetrics" },
                    { 9, "Urology" },
                    { 10, "Gastroenterology" },
                    { 11, "Pulmonology" },
                    { 12, "Psychiatry" },
                    { 13, "Endocrinology" },
                    { 14, "Nephrology" },
                    { 15, "Oncology" },
                    { 16, "Otolaryngology (ENT)" },
                    { 17, "General Surgery" },
                    { 18, "Internal Medicine" },
                    { 19, "Family Medicine" },
                    { 20, "Emergency Medicine" },
                    { 21, "Anesthesiology" },
                    { 22, "Rheumatology" },
                    { 23, "Hematology" },
                    { 24, "Infectious Diseases" },
                    { 25, "Allergy and Immunology" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Specialities");
        }
    }
}
