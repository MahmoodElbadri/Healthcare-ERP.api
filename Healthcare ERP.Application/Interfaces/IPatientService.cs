using Healthcare_ERP.Application.DTOs;

namespace Healthcare_ERP.Application.Interfaces;

public interface IPatientService
{
    Task<PatientDto> AddPatient(AddPatientDto patientDto);
    Task UpdatePatient(UpdatePatientDto patientDto);
    Task DeletePatient(int id);
    Task<PatientDto> GetPatientById(int id);
    Task<IEnumerable<PatientDto>> GetAllPatients();
}
