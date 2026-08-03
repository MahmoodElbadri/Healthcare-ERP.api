using AutoMapper;
using Healthcare_ERP.Application.DTOs;
using Healthcare_ERP.Domain.Entities;

namespace Healthcare_ERP.Application.Mappings;

public class AppointmentProfile : Profile
{
    public AppointmentProfile()
    {
        CreateMap<AddAppointmentDto, Appointment>();
        CreateMap<Appointment, AppointmentDto>();
    }
}
