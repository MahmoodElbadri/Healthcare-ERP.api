
using Healthcare_ERP.Application.Interfaces;
using Healthcare_ERP.Domain.Interfaces;
using AutoMapper;
using Healthcare_ERP.Application.DTOs;
using Healthcare_ERP.Domain.Exceptions;
using Healthcare_ERP.Domain.Entities;
using Healthcare_ERP.Domain.Enums;

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
        var appointments = await _unitOfWork.Appointments.Find(tmp=> tmp.DoctorId == dto.DoctorId && tmp.AppointmentDate == dto.AppointmentDate);
        if(appointments.Any())
        {
            throw new BadRequestException("Doctor is not available at this time");
        }

        appointment.Status = AppointmentStatus.Scheduled;

        await _unitOfWork.Appointments.Add(appointment);
        await _unitOfWork.CompleteAsync();
        return true;
    }

    public async Task<IEnumerable<AppointmentDto>> GetDoctorAppointments(int id)
    {
        var doctor = await _unitOfWork.Doctors.Find(tmp=> tmp.Id == id);
        
        if(!doctor.Any())
        {
            throw new NotFoundException("Doctor not found", id.ToString());
        }

        var appointments = await _unitOfWork.Appointments.Find(tmp=> tmp.DoctorId == id);

        if(!appointments.Any())
        {
            throw new NotFoundException("No appointments found for this doctor", id.ToString());
        }


        return _mapper.Map<IEnumerable<AppointmentDto>>(appointments);
    }

    public async Task<bool> UpdateAppointmentStatus(UpdateAppointmentStatusDto dto)
    {
        var appointment = await _unitOfWork.Appointments.Get(dto.AppointmentId);
        if (appointment == null) throw new NotFoundException("Appointment not found", dto.AppointmentId.ToString());
        appointment.Status = dto.Status;
        await _unitOfWork.Appointments.Update(appointment);
        await _unitOfWork.CompleteAsync();
        return true;
    }
}
