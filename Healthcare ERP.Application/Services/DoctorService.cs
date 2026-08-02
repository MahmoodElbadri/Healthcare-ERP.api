
using Healthcare_ERP.Application.DTOs;
using Healthcare_ERP.Application.Interfaces;
using Healthcare_ERP.Domain.Interfaces;

namespace Healthcare_ERP.Application.Services;

public class DoctorService : IDoctorService
{
    private readonly IUnitOfWork _unitOfWork;
    public DoctorService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
    public Task AddDoctor(DoctorDto doctorDto)
    {
        throw new NotImplementedException();
    }

    public Task DeleteDoctor(int id)
    {
        throw new NotImplementedException();
    }

    public Task GetAllDoctors()
    {
        throw new NotImplementedException();
    }

    public Task GetDoctorById(int id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateDoctor(DoctorDto doctorDto)
    {
        throw new NotImplementedException();
    }
}
