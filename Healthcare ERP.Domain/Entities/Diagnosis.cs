namespace Healthcare_ERP.Domain.Entities;

public class Diagnosis: BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public Appointment? Appointment { get; set; }
    public int AppointmentId { get; set; }
}
