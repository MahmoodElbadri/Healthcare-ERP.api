using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Healthcare_ERP.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedingMedications : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Medications",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "Name", "Notes", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 9, 5, 9, 9, 30, 514, DateTimeKind.Utc).AddTicks(5846), false, "Paracetamol", "مسكن وخافض للحرارة - 500mg", null },
                    { 2, new DateTime(2026, 9, 5, 9, 9, 30, 514, DateTimeKind.Utc).AddTicks(7572), false, "Ibuprofen", "مسكن ومضاد التهاب غير ستيرويدي", null },
                    { 3, new DateTime(2026, 9, 5, 9, 9, 30, 514, DateTimeKind.Utc).AddTicks(7577), false, "Amoxicillin", "مضاد حيوي من مجموعة البنسلين", null },
                    { 4, new DateTime(2026, 9, 5, 9, 9, 30, 514, DateTimeKind.Utc).AddTicks(7579), false, "Azithromycin", "مضاد حيوي من مجموعة الماكروليدات", null },
                    { 5, new DateTime(2026, 9, 5, 9, 9, 30, 514, DateTimeKind.Utc).AddTicks(7581), false, "Ciprofloxacin", "مضاد حيوي واسع المجال - فلوروكينولون", null },
                    { 6, new DateTime(2026, 9, 5, 9, 9, 30, 514, DateTimeKind.Utc).AddTicks(7594), false, "Metformin", "خافض لسكر الدم - لمرضى السكري النوع الثاني", null },
                    { 7, new DateTime(2026, 9, 5, 9, 9, 30, 514, DateTimeKind.Utc).AddTicks(7595), false, "Insulin Glargine", "أنسولين طويل المفعول", null },
                    { 8, new DateTime(2026, 9, 5, 9, 9, 30, 514, DateTimeKind.Utc).AddTicks(7597), false, "Amlodipine", "خافض لضغط الدم - حاصرات قنوات الكالسيوم", null },
                    { 9, new DateTime(2026, 9, 5, 9, 9, 30, 514, DateTimeKind.Utc).AddTicks(7598), false, "Losartan", "خافض لضغط الدم - حاصرات مستقبلات الأنجيوتنسين", null },
                    { 10, new DateTime(2026, 9, 5, 9, 9, 30, 514, DateTimeKind.Utc).AddTicks(7602), false, "Atorvastatin", "خافض للكوليسترول - ستاتين", null },
                    { 11, new DateTime(2026, 9, 5, 9, 9, 30, 514, DateTimeKind.Utc).AddTicks(7603), false, "Omeprazole", "مثبط مضخة البروتون - لقرحة المعدة والارتجاع", null },
                    { 12, new DateTime(2026, 9, 5, 9, 9, 30, 514, DateTimeKind.Utc).AddTicks(7605), false, "Ranitidine", "مضاد للحموضة - حاصرات H2 (الاستخدام محدود)", null },
                    { 13, new DateTime(2026, 9, 5, 9, 9, 30, 514, DateTimeKind.Utc).AddTicks(7606), false, "Salbutamol", " موسع للشعب الهوائية - بخاخ للربو", null },
                    { 14, new DateTime(2026, 9, 5, 9, 9, 30, 514, DateTimeKind.Utc).AddTicks(7608), false, "Prednisolone", "كورتيكوستيرويد مضاد للالتهاب", null },
                    { 15, new DateTime(2026, 9, 5, 9, 9, 30, 514, DateTimeKind.Utc).AddTicks(7609), false, "Dexamethasone", "كورتيكوستيرويد قوي المفعول", null },
                    { 16, new DateTime(2026, 9, 5, 9, 9, 30, 514, DateTimeKind.Utc).AddTicks(7610), false, "Chlorpheniramine", "مضاد هيستامين للحساسية", null },
                    { 17, new DateTime(2026, 9, 5, 9, 9, 30, 514, DateTimeKind.Utc).AddTicks(7612), false, "Cetirizine", "مضاد هيستامين من الجيل الثاني - غير منوّم", null },
                    { 18, new DateTime(2026, 9, 5, 9, 9, 30, 514, DateTimeKind.Utc).AddTicks(7615), false, "Acetylsalicylic Acid (Aspirin)", "مميع للدم ومسكن", null },
                    { 19, new DateTime(2026, 9, 5, 9, 9, 30, 514, DateTimeKind.Utc).AddTicks(7617), false, "Clopidogrel", "مضاد لتجميع الصفائح الدموية", null },
                    { 20, new DateTime(2026, 9, 5, 9, 9, 30, 514, DateTimeKind.Utc).AddTicks(7618), false, "Warfarin", "مضاد تخثر - يتطلب مراقبة INR", null },
                    { 21, new DateTime(2026, 9, 5, 9, 9, 30, 514, DateTimeKind.Utc).AddTicks(7620), false, "Levothyroxine", "هرمون الغدة الدرقية - لقصور الدرقية", null },
                    { 22, new DateTime(2026, 9, 5, 9, 9, 30, 514, DateTimeKind.Utc).AddTicks(7621), false, "Metoprolol", "حاصرات بيتا - لضغط الدم وقصور القلب", null },
                    { 23, new DateTime(2026, 9, 5, 9, 9, 30, 514, DateTimeKind.Utc).AddTicks(7623), false, "Enalapril", "مثبطات الإنزيم المحول للأنجيوتنسين", null },
                    { 24, new DateTime(2026, 9, 5, 9, 9, 30, 514, DateTimeKind.Utc).AddTicks(7624), false, "Furosemide", "مدرّ للبول - لاحتباس السوائل", null },
                    { 25, new DateTime(2026, 9, 5, 9, 9, 30, 514, DateTimeKind.Utc).AddTicks(7626), false, "Gliclazide", "خافض لسكر الدم من مجموعة السلفونيل يوريا", null },
                    { 26, new DateTime(2026, 9, 5, 9, 9, 30, 514, DateTimeKind.Utc).AddTicks(7627), false, "Diazepam", "مهدئ - بنزوديازيبين (يُصرف بوصفة مضبوطة)", null },
                    { 27, new DateTime(2026, 9, 5, 9, 9, 30, 514, DateTimeKind.Utc).AddTicks(7628), false, "Tramadol", "مسكن أفيوني متوسط القوة (يُصرف بوصفة مضبوطة)", null },
                    { 28, new DateTime(2026, 9, 5, 9, 9, 30, 514, DateTimeKind.Utc).AddTicks(7630), false, "Gentamicin", "مضاد حيوي أمينوغليكوزيد - للحقن", null },
                    { 29, new DateTime(2026, 9, 5, 9, 9, 30, 514, DateTimeKind.Utc).AddTicks(7631), false, "Clotrimazole", "مضاد فطري موضعي", null },
                    { 30, new DateTime(2026, 9, 5, 9, 9, 30, 514, DateTimeKind.Utc).AddTicks(7632), false, "ORS (Oral Rehydration Salts)", "أملاح الإماهة الفموية - للجفاف", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 30);
        }
    }
}
