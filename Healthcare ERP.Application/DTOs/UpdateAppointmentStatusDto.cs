using Healthcare_ERP.Domain.Enums;

namespace Healthcare_ERP.Application.DTOs;

public class UpdateAppointmentStatusDto
{
    public int AppointmentId { get; set; }
    public AppointmentStatus Status { get; set; }
}