// 1. الدواء الثابت في السيستم (قاموس الأدوية)
namespace Healthcare_ERP.Domain.Entities;

// 3. الروشتة نفسها
public class Prescription : BaseEntity
{
    public int AppointmentId { get; set; }
    public Appointment? Appointment { get; set; }
    
    // الروشتة فيها لستة من العناصر مش الأدوية المباشرة
    public List<PrescriptionItem> Items { get; set; } = new List<PrescriptionItem>();
}