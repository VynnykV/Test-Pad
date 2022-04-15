using AutoMapper;
using TestPad.Common.DTO.Question;
using TestPad.DAL.Entities;

namespace TestPad.BLL.MappingProfiles;

public class QuestionProfile : Profile
{
    public QuestionProfile()
    {
        CreateMap<Question, QuestionDto>();
    }
}