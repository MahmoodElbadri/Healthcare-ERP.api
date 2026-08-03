
using AutoMapper;
using Healthcare_ERP.Application.DTOs;
using Healthcare_ERP.Application.Interfaces;
using Healthcare_ERP.Domain.Entities;
using Healthcare_ERP.Domain.Exceptions;
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
    public async Task<DoctorDto> AddDoctor(AddDoctorDto doctorDto)
    {
        var doctorModel = _mapper.Map<Doctor>(doctorDto);
        var doctorAdded = await _unitOfWork.Doctors.Add(doctorModel);
        await _unitOfWork.CompleteAsync();
        return _mapper.Map<DoctorDto>(doctorAdded);
    }

    public async Task DeleteDoctor(int id)
    {
        var doctor = await _unitOfWork.Doctors.Get(id);
        if (doctor == null) throw new NotFoundException("Doctor not found", id.ToString());
        await _unitOfWork.Doctors.Remove(doctor);
        await _unitOfWork.CompleteAsync();
    }

    public async Task<IEnumerable<DoctorDto>> GetAllDoctors()
    {
        var doctors = await _unitOfWork.Doctors.GetAll();
        return _mapper.Map<IEnumerable<DoctorDto>>(doctors);
    }

    public async Task<DoctorDto> GetDoctorById(int id)
    {
        var doctor = await _unitOfWork.Doctors.Get(id);
        if (doctor == null) throw new NotFoundException("Doctor not found", id.ToString());
        return _mapper.Map<DoctorDto>(doctor);
    }

    public async Task UpdateDoctor(UpdateDoctorDto doctorDto)
    {
        var doctor = await _unitOfWork.Doctors.Get(doctorDto.Id);
        if (doctor == null) throw new NotFoundException("Doctor not found", doctorDto.Id.ToString());
        _mapper.Map(doctorDto, doctor);
        await _unitOfWork.Doctors.Update(doctor);
        await _unitOfWork.CompleteAsync();
    }
}
