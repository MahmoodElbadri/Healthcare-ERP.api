namespace Healthcare_ERP.Application.DTOs;

public class AddPrescriptionItemDto
{
    public int PrescriptionId { get; set; }
    public int MedicationId { get; set; }
    public string Dosage { get; set; } = string.Empty;
    public int DurationInDays { get; set; }
}