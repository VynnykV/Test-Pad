using TestPad.Common.DTO.Auth;
using TestPad.Common.DTO.User;

namespace TestPad.BLL.Interfaces;

public interface IUserService
{
    public Task<UserDto> CreateAsync(RegisterDto registerDto);
    public Task<UserDto> GetByEmailAsync(string email);
    Task<bool> CheckPasswordAsync(UserDto userDto, string password);
}