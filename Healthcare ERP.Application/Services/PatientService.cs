using AutoMapper;
using Healthcare_ERP.Application.DTOs;
using Healthcare_ERP.Application.Interfaces;
using Healthcare_ERP.Domain.Entities;
using Healthcare_ERP.Domain.Exceptions;
using Healthcare_ERP.Domain.Interfaces;

namespace Healthcare_ERP.Application.Services;

public class PatientService : IPatientService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    public PatientService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }
    public async Task<PatientDto> AddPatient(AddPatientDto patientDto)
    {
        var patientModel = _mapper.Map<Patient>(patientDto);
        var patientAdded = await _unitOfWork.Patients.Add(patientModel);
        await _unitOfWork.CompleteAsync();
        return _mapper.Map<PatientDto>(patientAdded);
    }

    public async Task DeletePatient(int id)
    {
        var patient = await _unitOfWork.Patients.Get(id);
        if (patient == null) throw new NotFoundException("Patient not found", id.ToString());
        await _unitOfWork.Patients.Remove(patient);
        await _unitOfWork.CompleteAsync();
    }

    public async Task<IEnumerable<PatientDto>> GetAllPatients()
    {
        var patients = await _unitOfWork.Patients.GetAll();
        return _mapper.Map<IEnumerable<PatientDto>>(patients);
    }

    public async Task<PatientDto> GetPatientById(int id)
    {
        var patient = await _unitOfWork.Patients.Get(id);
        if (patient == null) throw new NotFoundException("Patient not found", id.ToString());
        return _mapper.Map<PatientDto>(patient);
    }

    public async Task UpdatePatient(UpdatePatientDto patientDto)
    {
        var patient = await _unitOfWork.Patients.Get(patientDto.Id);
        if (patient == null) throw new NotFoundException("Patient not found", patientDto.Id.ToString());
        _mapper.Map(patientDto, patient);
        await _unitOfWork.Patients.Update(patient);
        await _unitOfWork.CompleteAsync();
    }
}
