using Healthcare_ERP.Domain.Entities;

namespace Healthcare_ERP.Application.DTOs;

public class PatientHistoryDto
{
    public List<AppointmentDto> Appointments { get; set; }
    public List<DiagnosisDto> Diagnoses { get; set; }
    public List<PrescriptionDto> Prescriptions { get; set; }
}