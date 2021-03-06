using System.ComponentModel.DataAnnotations;

namespace TestPad.Common.DTO.Auth;

public class LoginDto
{
    [Required]
    public string Email { get; set; } = default!;
    
    [Required]
    public string Password { get; set; } = default!;
}