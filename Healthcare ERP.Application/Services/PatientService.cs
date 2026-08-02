using AutoMapper;
using Healthcare_ERP.Application.DTOs;
using Healthcare_ERP.Application.Interfaces;
using Healthcare_ERP.Domain.Entities;
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

    public Task DeletePatient(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<PatientDto>> GetAllPatients()
    {
        var patients = await _unitOfWork.Patients.GetAll();
        return _mapper.Map<IEnumerable<PatientDto>>(patients);
    }

    public Task<PatientDto> GetPatientById(int id)
    {
        throw new NotImplementedException();
    }

    public Task UpdatePatient(PatientDto patientDto)
    {
        throw new NotImplementedException();
    }
}
