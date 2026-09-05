namespace Healthcare_ERP.Application.DTOs;

public class AddPrescriptionDto
{
    public int AppointmentId { get; set; }
    public int DiagnosisId { get; set; }
    public List<PrescriptionItemDto> Items { get; set; } = new List<PrescriptionItemDto>();
}