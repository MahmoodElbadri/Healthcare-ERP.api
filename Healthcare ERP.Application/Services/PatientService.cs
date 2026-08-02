using Healthcare_ERP.Application.DTOs;
using Healthcare_ERP.Application.Interfaces;
using Healthcare_ERP.Domain.Interfaces;

namespace Healthcare_ERP.Application.Services;

public class PatientService : IPatientService
{
    private readonly IUnitOfWork _unitOfWork;
    public PatientService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
    public Task AddPatient(PatientDto patientDto)
    {
        throw new NotImplementedException();
    }

    public Task DeletePatient(int id)
    {
        throw new NotImplementedException();
    }

    public Task GetAllPatients()
    {
        throw new NotImplementedException();
    }

    public Task GetPatientById(int id)
    {
        throw new NotImplementedException();
    }

    public Task UpdatePatient(PatientDto patientDto)
    {
        throw new NotImplementedException();
    }
}
