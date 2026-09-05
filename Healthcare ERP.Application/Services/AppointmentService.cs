
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

    public async Task<AppointmentDto> AddAppointment(AddAppointmentDto dto)
    {
        // 1. التحقق من صحة التاريخ
        if (dto.AppointmentDate < DateOnly.FromDateTime(DateTime.Now))
            throw new BadRequestException("Cannot book appointments in the past");

        // 2. جلب البيانات بشكل متسلسل (لكل عملية await)
        var doctor = await _unitOfWork.Doctors.Get(dto.DoctorId);
        if (doctor == null)
            throw new NotFoundException($"Doctor with ID {dto.DoctorId} not found");

        var patient = await _unitOfWork.Patients.Get(dto.PatientId);
        if (patient == null)
            throw new NotFoundException($"Patient with ID {dto.PatientId} not found");

        // 3. جلب المواعيد الموجودة
        var existingAppointments = await _unitOfWork.Appointments
            .Find(a => a.DoctorId == dto.DoctorId
                       && a.AppointmentDate == dto.AppointmentDate
                       && a.Status != AppointmentStatus.Cancelled);

        // 4. حساب رقم الدور
        var maxQueueNumber = existingAppointments
            .Select(a => a.QueueNumber)
            .DefaultIfEmpty(0)
            .Max();

        const int maxAppointmentsPerDay = 20;
        if (maxQueueNumber >= maxAppointmentsPerDay)
            throw new BadRequestException($"No available slots. Maximum {maxAppointmentsPerDay} appointments per day");

        // 5. إنشاء الموعد
        var appointment = _mapper.Map<Appointment>(dto);
        appointment.QueueNumber = maxQueueNumber + 1;
        appointment.Status = AppointmentStatus.Scheduled;

        await _unitOfWork.Appointments.Add(appointment);
        await _unitOfWork.CompleteAsync();

        // Assign the tracked entities so AutoMapper can map their properties (like DoctorName)
        appointment.Doctor = doctor;
        appointment.Patient = patient;

        return _mapper.Map<AppointmentDto>(appointment);
    }

    public async Task<IEnumerable<AppointmentDto>> GetDoctorAppointments(int id)
    {
        var doctor = await _unitOfWork.Doctors.Find(tmp => tmp.Id == id);

        if (!doctor.Any())
        {
            throw new NotFoundException("Doctor not found", id.ToString());
        }

        var appointments = await _unitOfWork.Appointments.GetWithIncludesByIdAsync(id, tmp => tmp.Doctor , tmp => tmp.Patient);

        if (appointments == null)
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

    public async Task<IEnumerable<AppointmentDto>> GetAllAppointments()
    {
        var appointments = await _unitOfWork.Appointments.GetAllWithIncludes(tmp => tmp.Doctor, tmp => tmp.Patient);
        //foreach (var appointment in appointments)
        //{
        //    appointment.Doctor = await _unitOfWork.Doctors.Get(appointment.DoctorId);
        //    appointment.Patient = await _unitOfWork.Patients.Get(appointment.PatientId);
        //}
        return _mapper.Map<IEnumerable<AppointmentDto>>(appointments);
    }

    
}
