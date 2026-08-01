using Healthcare_ERP.Domain.Enums;

namespace Healthcare_ERP.Domain.Entities;

public class Patient : BaseEntity
{
    public string Name { get; set; }
    public Gender Gender { get; set; }
    public DateOnly DateOfBirth { get; set; }
    public string PhoneNumber { get; set; }
    public List<Appointment> Appointments { get; set; }
    // Computed property
    public int Age
    {
        get
        {
            var today = DateOnly.FromDateTime(DateTime.UtcNow);
            var age = today.Year - DateOfBirth.Year;
            if (DateOfBirth > today.AddYears(-age)) age--;
            return age;
        }
    }
}
