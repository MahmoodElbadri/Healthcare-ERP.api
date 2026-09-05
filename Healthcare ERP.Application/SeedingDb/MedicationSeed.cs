using Healthcare_ERP.Domain.Entities;

namespace Healthcare_ERP.Application.SeedingDb;

public static class MedicationSeed
{
    public static readonly List<Medication> Medications = new()
    {
       new Medication { Id = 1,  Name = "Paracetamol",                    Notes = "مسكن وخافض للحرارة - 500mg" },
            new Medication { Id = 2,  Name = "Ibuprofen",                      Notes = "مسكن ومضاد التهاب غير ستيرويدي" },
            new Medication { Id = 3,  Name = "Amoxicillin",                    Notes = "مضاد حيوي من مجموعة البنسلين" },
            new Medication { Id = 4,  Name = "Azithromycin",                   Notes = "مضاد حيوي من مجموعة الماكروليدات" },
            new Medication { Id = 5,  Name = "Ciprofloxacin",                  Notes = "مضاد حيوي واسع المجال - فلوروكينولون" },
            new Medication { Id = 6,  Name = "Metformin",                      Notes = "خافض لسكر الدم - لمرضى السكري النوع الثاني" },
            new Medication { Id = 7,  Name = "Insulin Glargine",               Notes = "أنسولين طويل المفعول" },
            new Medication { Id = 8,  Name = "Amlodipine",                     Notes = "خافض لضغط الدم - حاصرات قنوات الكالسيوم" },
            new Medication { Id = 9,  Name = "Losartan",                       Notes = "خافض لضغط الدم - حاصرات مستقبلات الأنجيوتنسين" },
            new Medication { Id = 10, Name = "Atorvastatin",                   Notes = "خافض للكوليسترول - ستاتين" },
            new Medication { Id = 11, Name = "Omeprazole",                     Notes = "مثبط مضخة البروتون - لقرحة المعدة والارتجاع" },
            new Medication { Id = 12, Name = "Ranitidine",                     Notes = "مضاد للحموضة - حاصرات H2 (الاستخدام محدود)" },
            new Medication { Id = 13, Name = "Salbutamol",                     Notes = " موسع للشعب الهوائية - بخاخ للربو" },
            new Medication { Id = 14, Name = "Prednisolone",                   Notes = "كورتيكوستيرويد مضاد للالتهاب" },
            new Medication { Id = 15, Name = "Dexamethasone",                  Notes = "كورتيكوستيرويد قوي المفعول" },
            new Medication { Id = 16, Name = "Chlorpheniramine",               Notes = "مضاد هيستامين للحساسية" },
            new Medication { Id = 17, Name = "Cetirizine",                     Notes = "مضاد هيستامين من الجيل الثاني - غير منوّم" },
            new Medication { Id = 18, Name = "Acetylsalicylic Acid (Aspirin)", Notes = "مميع للدم ومسكن" },
            new Medication { Id = 19, Name = "Clopidogrel",                    Notes = "مضاد لتجميع الصفائح الدموية" },
            new Medication { Id = 20, Name = "Warfarin",                       Notes = "مضاد تخثر - يتطلب مراقبة INR" },
            new Medication { Id = 21, Name = "Levothyroxine",                  Notes = "هرمون الغدة الدرقية - لقصور الدرقية" },
            new Medication { Id = 22, Name = "Metoprolol",                     Notes = "حاصرات بيتا - لضغط الدم وقصور القلب" },
            new Medication { Id = 23, Name = "Enalapril",                      Notes = "مثبطات الإنزيم المحول للأنجيوتنسين" },
            new Medication { Id = 24, Name = "Furosemide",                     Notes = "مدرّ للبول - لاحتباس السوائل" },
            new Medication { Id = 25, Name = "Gliclazide",                     Notes = "خافض لسكر الدم من مجموعة السلفونيل يوريا" },
            new Medication { Id = 26, Name = "Diazepam",                       Notes = "مهدئ - بنزوديازيبين (يُصرف بوصفة مضبوطة)" },
            new Medication { Id = 27, Name = "Tramadol",                       Notes = "مسكن أفيوني متوسط القوة (يُصرف بوصفة مضبوطة)" },
            new Medication { Id = 28, Name = "Gentamicin",                     Notes = "مضاد حيوي أمينوغليكوزيد - للحقن" },
            new Medication { Id = 29, Name = "Clotrimazole",                   Notes = "مضاد فطري موضعي" },
            new Medication { Id = 30, Name = "ORS (Oral Rehydration Salts)",   Notes = "أملاح الإماهة الفموية - للجفاف" }
    };
}