namespace Healthcare_ERP.Application.DTOs;

public class UpdatePatientDto
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public DateOnly DateOfBirth { get; set; }
    public string Gender { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
}