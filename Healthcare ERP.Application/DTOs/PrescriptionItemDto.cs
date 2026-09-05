namespace Healthcare_ERP.Application.DTOs;

public class PrescriptionItemDto
{
    public int MedicationId { get; set; }
    public string Dosage { get; set; } = string.Empty;
    public int DurationInDays { get; set; }
    public string Instructions { get; set; } = string.Empty;
}