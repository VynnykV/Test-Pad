using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using TestPad.BLL.Exceptions;
using TestPad.BLL.Interfaces;
using TestPad.BLL.Services.Abstract;
using TestPad.Common.DTO.Auth;
using TestPad.Common.DTO.User;
using TestPad.DAL.Context;
using TestPad.DAL.Entities;

namespace TestPad.BLL.Services;

public class UserService : BaseService, IUserService
{
    private readonly UserManager<User> _userManager;

    public UserService(
        UserManager<User> userManager,
        IMapper mapper,
        TestPadContext context) : base(context, mapper)
    {
        _userManager = userManager;
    }

    public async Task<UserDto> CreateAsync(RegisterDto registerDto)
    {
        var existedUser = await _context.Users
            .FirstOrDefaultAsync(u => u.Email == registerDto.Email || u.UserName == registerDto.Username);
        
        if (existedUser is not null)
        {
            CheckIfUserEmailOrUsernameUnique(existedUser, registerDto);
        }

        var user = new User()
        {
            UserName = registerDto.Username,
            Email = registerDto.Email
        };
        await _userManager.CreateAsync(user, registerDto.Password);
        
        return _mapper.Map<UserDto>(await GetByEmailAsync(registerDto.Email));
    }

    public async Task<UserDto> GetByEmailAsync(string email)
    {
        var userEntity = await _context.Users
            .FirstOrDefaultAsync(u => u.Email == email);
        
        if (userEntity is null)
        {
            throw new NotFoundException(nameof(User));
        }

        return _mapper.Map<UserDto>(userEntity);
    }

    public async Task<bool> CheckPasswordAsync(UserDto userDto, string password)
    {
        var userEntity = await _context.Users
            .FirstOrDefaultAsync(u => u.Email == userDto.Email);

        if (userEntity is null)
        {
            throw new NotFoundException(nameof(User));
        }

        return await _userManager.CheckPasswordAsync(userEntity, password);
    }

    private void CheckIfUserEmailOrUsernameUnique(User user, RegisterDto registerDto)
    {
        if (registerDto.Email == user.Email)
        {
            throw new UserWithSuchPropertyAlreadyExists("email");
        }
        else if(registerDto.Username == user.UserName)
        {
            throw new UserWithSuchPropertyAlreadyExists("username");
        }
    }
}