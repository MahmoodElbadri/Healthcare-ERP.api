
using AutoMapper;
using Healthcare_ERP.Application.DTOs;
using Healthcare_ERP.Application.Interfaces;
using Healthcare_ERP.Domain.Entities;
using Healthcare_ERP.Domain.Interfaces;

namespace Healthcare_ERP.Application.Services;

public class DoctorService : IDoctorService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    public DoctorService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }
    public async Task<DoctorDto> AddDoctor(DoctorDto doctorDto)
    {
        var doctorModel = _mapper.Map<Doctor>(doctorDto);
        var doctorAdded = await _unitOfWork.Doctors.Add(doctorModel);
        await _unitOfWork.CompleteAsync();
        return _mapper.Map<DoctorDto>(doctorAdded);
    }

    public Task DeleteDoctor(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<DoctorDto>> GetAllDoctors()
    {
        var doctors = await _unitOfWork.Doctors.GetAll();
        return _mapper.Map<IEnumerable<DoctorDto>>(doctors);
    }

    public Task<DoctorDto> GetDoctorById(int id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateDoctor(DoctorDto doctorDto)
    {
        throw new NotImplementedException();
    }
}
