using AutoMapper;
using TestPad.Common.DTO.Answer;
using TestPad.DAL.Entities;

namespace TestPad.BLL.MappingProfiles;

public class AnswerProfile : Profile
{
    public AnswerProfile()
    {
        CreateMap<Answer, AnswerDto>();
    }
}