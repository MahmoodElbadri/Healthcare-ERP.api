using Healthcare_ERP.Application.DTOs;

namespace Healthcare_ERP.Application.Interfaces;

public interface IExaminationService
{
    Task SaveExaminationAsync(AddDiagnosisDto diagnosisDto, AddPrescriptionDto prescriptionDto);
}