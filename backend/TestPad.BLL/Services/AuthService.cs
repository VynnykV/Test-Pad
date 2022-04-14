using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using TestPad.BLL.Exceptions;
using TestPad.BLL.Interfaces;
using TestPad.Common.DTO.Auth;
using TestPad.Common.DTO.User;

namespace TestPad.BLL.Services;

public class AuthService : IAuthService
{
    private readonly IUserService _userService;
    private readonly IConfiguration _configuration;

    public AuthService(IUserService userService, IConfiguration configuration)
    {
        _userService = userService;
        _configuration = configuration;
    }

    public async Task<UserDto> Register(RegisterDto registerDto)
    {
        return await _userService.CreateAsync(registerDto);
    }

    public async Task<AuthUserDto> Login(LoginDto loginDto)
    {
        var user = await _userService.GetByEmailAsync(loginDto.Email);
        if (user is not null && await _userService.CheckPasswordAsync(user, loginDto.Password))
        {
            var authClaims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(ClaimTypes.Email, user.Email),
                new Claim(ClaimTypes.Name, user.UserName)
            };
            var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWTSettings:Secret"]));

            var token = new JwtSecurityToken(
                issuer: _configuration["JWTSettings:ValidIssuer"],
                audience: _configuration["JWTSettings:ValidAudience"],
                claims: authClaims,
                expires: DateTime.UtcNow.AddHours(3),
                signingCredentials: new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256)
            );

            var jwt = new JwtSecurityTokenHandler().WriteToken(token);

            return new AuthUserDto()
            {
                Token = new AccessTokenDto() {Token = jwt, Expiration = token.ValidTo},
                User = user
            };
        }

        throw new WrongCredentialsException();
    }
}