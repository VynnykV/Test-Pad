using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TestPad.BLL.Interfaces;
using TestPad.Common.DTO.User;
using TestPad.WebAPI.Extensions;

namespace TestPad.WebAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
[Authorize]
public class UsersController : ControllerBase
{
    private readonly IUserService _userService;
    
    public UsersController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpGet("fromToken")]
    public async Task<ActionResult<UserDto>> GetUserFromToken()
    {
        return Ok(await _userService.GetByIdAsync(this.GetUserIdFromToken()));
    }
}