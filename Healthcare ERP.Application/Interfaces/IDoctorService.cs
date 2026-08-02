using Healthcare_ERP.Application.DTOs;
using Healthcare_ERP.Domain.Interfaces;

namespace Healthcare_ERP.Application.Interfaces;

public interface IDoctorService
{
    Task<DoctorDto> AddDoctor(DoctorDto doctorDto);
    Task UpdateDoctor(DoctorDto doctorDto);
    Task DeleteDoctor(int id);
    Task<DoctorDto> GetDoctorById(int id);
    Task<IEnumerable<DoctorDto>> GetAllDoctors();
}
