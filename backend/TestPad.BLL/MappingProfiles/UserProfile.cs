using AutoMapper;
using TestPad.Common.DTO.Auth;
using TestPad.Common.DTO.User;
using TestPad.DAL.Entities;

namespace TestPad.BLL.MappingProfiles;

public class UserProfile : Profile
{
    public UserProfile()
    {
        CreateMap<RegisterDto, User>()
            .ForMember(d => d.UserName, 
                opt => opt.MapFrom(s => s.Username));
        CreateMap<User, UserDto>()
            .ForMember(d => d.Username, 
                opt => opt.MapFrom(s => s.UserName));
    }
}