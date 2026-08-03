

using Healthcare_ERP.Application.DTOs;

namespace Healthcare_ERP.Application.Interfaces;

public interface IAppointmentService
{
    Task<bool> AddAppointment(AddAppointmentDto dto);
}
