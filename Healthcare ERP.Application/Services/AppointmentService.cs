
using Healthcare_ERP.Application.Interfaces;
using Healthcare_ERP.Domain.Interfaces;
using AutoMapper;
using Healthcare_ERP.Application.DTOs;
using Healthcare_ERP.Domain.Exceptions;
using Healthcare_ERP.Domain.Entities;
namespace Healthcare_ERP.Application.Services;

public class AppointmentService : IAppointmentService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    public AppointmentService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<bool> AddAppointment(AddAppointmentDto dto)
    {
        var isDoctorExist = await _unitOfWork.Doctors.Get(dto.DoctorId);
        var isPatientExist = await _unitOfWork.Patients.Get(dto.PatientId);
        if (isDoctorExist == null) throw new NotFoundException("Doctor not found", dto.DoctorId.ToString());
        if (isPatientExist == null) throw new NotFoundException("Patient not found", dto.PatientId.ToString());

        var appointment = _mapper.Map<Appointment>(dto);

        // حدد النوع صراحة
        var appointments = _unitOfWork.Appointments.GetAll();
        if (appointments.Result.Any<Appointment>(a => a.DoctorId == dto.DoctorId && a.AppointmentDate == dto.AppointmentDate))
        {
            throw new BadRequestException("Doctor is not available at this time");
        }

        await _unitOfWork.Appointments.Add(appointment);
        await _unitOfWork.CompleteAsync();
        return true;
    }
}
