using Healthcare_ERP.Domain.Entities;

namespace Healthcare_ERP.Application.DTOs;

public class AddAppointmentDto
{
    public DateOnly AppointmentDate { get; set; }
    public int PatientId { get; set; }
    public int DoctorId { get; set; }
    public string? Notes { get; set; }
}