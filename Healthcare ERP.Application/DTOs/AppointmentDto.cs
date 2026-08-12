using Healthcare_ERP.Domain.Enums;

namespace Healthcare_ERP.Application.DTOs;

public class AppointmentDto
{
    public int Id { get; set; }
    public DateOnly AppointmentDate { get; set; }
    public string Status { get; set; }
    // Navigation property
    public string? PatientName { get; set; }
    public string? DoctorName { get; set; }
    public string? Notes { get; set; }
    public int QueueNumber { get; set; }
}

