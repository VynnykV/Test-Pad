using TestPad.Common.DTO.Auth;
using TestPad.Common.DTO.User;

namespace TestPad.BLL.Interfaces;

public interface IAuthService
{
    public Task<UserDto> Register(RegisterDto registerDto);
    public Task<AuthUserDto> Login(LoginDto loginDto);
}