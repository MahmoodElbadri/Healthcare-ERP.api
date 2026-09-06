namespace Healthcare_ERP.Application.DTOs;

public class DiagnosisDto
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public int AppointmentId { get; set; }
}