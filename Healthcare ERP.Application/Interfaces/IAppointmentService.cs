

using Healthcare_ERP.Application.DTOs;


namespace Healthcare_ERP.Application.Interfaces;

public interface IAppointmentService
{
    Task<bool> AddAppointment(AddAppointmentDto dto);
    Task<IEnumerable<AppointmentDto>> GetDoctorAppointments(int id);
    // Task<bool> GetPatientAppointments(int id);
    Task<bool> UpdateAppointmentStatus(UpdateAppointmentStatusDto dto);
}
