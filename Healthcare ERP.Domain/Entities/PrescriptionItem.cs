// 1. الدواء الثابت في السيستم (قاموس الأدوية)
using Healthcare_ERP.Domain.Entities;
// 2. السطر الواحد جوه الروشتة (بيربط الروشتة بالدواء مع الجرعة)
public class PrescriptionItem : BaseEntity
{
    public int PrescriptionId { get; set; }
    public Prescription? Prescription { get; set; }

    public int MedicationId { get; set; }
    public Medication? Medication { get; set; }

    // الأفضل نخلي الجرعة string عشان الدكتور يقدر يكتب "قرص كل 12 ساعة"
    public string Dosage { get; set; } = string.Empty;
    public int DurationInDays { get; set; }
}
