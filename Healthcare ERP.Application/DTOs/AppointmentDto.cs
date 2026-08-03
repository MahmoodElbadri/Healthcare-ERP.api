using Healthcare_ERP.Domain.Enums;

namespace Healthcare_ERP.Application.DTOs;

public class AppointmentDto
{
        public DateTime AppointmentDate { get; set; }
        public AppointmentStatus Status { get; set; }
        // Navigation property
        public int PatientId { get; set; }
        public int DoctorId { get; set; }
        public string? Notes { get; set; }
    }

