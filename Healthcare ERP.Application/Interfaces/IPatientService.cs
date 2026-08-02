using Healthcare_ERP.Application.DTOs;

namespace Healthcare_ERP.Application.Interfaces;

public interface IPatientService
{
    Task AddPatient(PatientDto patientDto);
    Task UpdatePatient(PatientDto patientDto);
    Task DeletePatient(int id);
    Task GetPatientById(int id);
    Task GetAllPatients();
}
