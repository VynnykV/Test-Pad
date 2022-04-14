using TestPad.Common.DTO.User;

namespace TestPad.Common.DTO.Auth;

public class AuthUserDto
{
    public UserDto User { get; set; } = default!;
    public AccessTokenDto Token { get; set; } = default!;
}