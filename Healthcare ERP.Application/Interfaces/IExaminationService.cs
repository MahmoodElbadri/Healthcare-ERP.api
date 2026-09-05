using Healthcare_ERP.Application.DTOs;

namespace Healthcare_ERP.Application.Interfaces;

public interface IExaminationService
{
    /// <summary>
    /// Save Diagnosis and Prescription and update Appointment status to Completed
    /// </summary>
    /// <param name="diagnosisDto">Contains information about the diagnosis</param>
    /// <param name="prescriptionDto">Contains information about the prescription</param>
    /// <returns>void</returns>
    Task SaveExaminationAsync(AddDiagnosisDto diagnosisDto, AddPrescriptionDto prescriptionDto);
}