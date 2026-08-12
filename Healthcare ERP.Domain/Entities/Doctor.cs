namespace Healthcare_ERP.Domain.Entities;

public class Doctor : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public string Specialty { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
    public List<Appointment> Appointments { get; set; } = new List<Appointment>();
    public int NumberOfAttendees { get; set; } = 20;
}
