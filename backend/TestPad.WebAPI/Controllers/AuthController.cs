using Microsoft.AspNetCore.Mvc;
using TestPad.BLL.Interfaces;
using TestPad.Common.DTO.Auth;
using TestPad.Common.DTO.User;

namespace TestPad.WebAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly IAuthService _authService;

    public AuthController(IAuthService authService)
    {
        _authService = authService;
    }

    [HttpPost]
    [Route("register")]
    public async Task<ActionResult<UserDto>> Register(RegisterDto registerDto)
    {
        return Ok(await _authService.Register(registerDto));
    }
    
    [HttpPost]
    [Route("login")]
    public async Task<ActionResult<UserDto>> Login(LoginDto loginDto)
    {
        try
        {
            return Ok(await _authService.Login(loginDto));
        }
        catch (Exception e)
        {
            return Unauthorized(e.Message);
        }
    }
}