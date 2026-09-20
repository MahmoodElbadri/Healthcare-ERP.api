using System.ComponentModel.DataAnnotations;

namespace Healthcare_ERP.Application.DTOs;

public class RegisterDto
{
    [Required]
    [EmailAddress]
    public string Email { get; set; } = string.Empty;

    [Required]
    [MinLength(6)]
    public string Password { get; set; } = string.Empty;

    [Required]
    [Compare("Password")]
    public string ConfirmPassword { get; set; } = string.Empty;

    // public string Role { get; set; } = string.Empty;
    [Required]
    public string PhoneNumber { get; set; } = string.Empty;
    
    [Required]
    public string FullName { get; set; } = string.Empty;

    [Required]
    public string Specialization { get; set; } = string.Empty;
}