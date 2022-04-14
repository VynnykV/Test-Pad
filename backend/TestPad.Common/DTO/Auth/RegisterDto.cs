using System.ComponentModel.DataAnnotations;

namespace TestPad.Common.DTO.Auth;

public class RegisterDto
{
    [Required] 
    public string Username { get; set; } = default!;
    
    [Required] 
    public string Email { get; set; } = default!;

    [Required] 
    public string Password { get; set; } = default!;

    [Required] 
    [Compare("Password")] 
    public string ConfirmPassword { get; set; } = default!;
}