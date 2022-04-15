using AutoMapper;
using TestPad.Common.DTO.Test;
using TestPad.DAL.Entities;

namespace TestPad.BLL.MappingProfiles;

public class TestProfile : Profile
{
    public TestProfile()
    {
        CreateMap<Test, TestDto>();
    }
}