using Healthcare_ERP.Application.DTOs;
using Healthcare_ERP.Application.Interfaces;
using Healthcare_ERP.Domain.Entities;
using Healthcare_ERP.Domain.Interfaces;
using AutoMapper;
using Healthcare_ERP.Domain.Enums;
using Healthcare_ERP.Domain.Exceptions;

namespace Healthcare_ERP.Application.Services;

public class ExaminationService:IExaminationService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public ExaminationService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task SaveExaminationAsync(AddDiagnosisDto diagnosisDto, AddPrescriptionDto prescriptionDto)
    {
        var diagnosis = _mapper.Map<Diagnosis>(diagnosisDto);
        var prescription = _mapper.Map<Prescription>(prescriptionDto);
        await _unitOfWork.Diagnoses.Add(diagnosis);
        await _unitOfWork.Prescriptions.Add(prescription);
        var appointment = await _unitOfWork.Appointments.Get(diagnosisDto.AppointmentId);
        if(appointment==null) throw new NotFoundException("Appointment not found", diagnosisDto.AppointmentId.ToString());
        appointment.Status = AppointmentStatus.Completed;
        await _unitOfWork.Appointments.Update(appointment);
        await _unitOfWork.CompleteAsync();
    }
}