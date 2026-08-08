using AutoMapper;

namespace Healthcare_ERP.Application.Mappings;

public class SpecialityProfile:Profile
{
    public SpecialityProfile()
    {
        CreateMap<Healthcare_ERP.Domain.Entities.Speciality, Healthcare_ERP.Application.DTOs.SpecialityDto>().ReverseMap();
    }
}
