using Microsoft.AspNetCore.Identity;

namespace Healthcare_ERP.Domain.Entities;

public class ApplicationUser:IdentityUser
{
    //public Guid Id { get; set; }   
    public string FullName { get; set; } = string.Empty;
    public string Role { get; set; } = string.Empty;
    public bool IsActive { get; set; } = true;
    public DateTime? LastLogin { get; set; } 

}