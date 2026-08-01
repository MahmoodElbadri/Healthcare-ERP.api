using Healthcare_ERP.Domain.Enums;

namespace Healthcare_ERP.Domain.Entities;

public class Appointment: BaseEntity
{
    public DateTime AppointmentDate { get; set; }
    public AppointmentStatus Status { get; set; }
    // Navigation property
    public Patient? Patient { get; set; }
    public string? Notes { get; set; }
}
