using Healthcare_ERP.Application.DTOs;

namespace Healthcare_ERP.Application.Interfaces;

public interface ISpecialityService
{
    Task<IEnumerable<SpecialityDto>> GetAllSpecialities();
}