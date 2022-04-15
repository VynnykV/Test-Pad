using TestPad.Common.DTO.Answer;

namespace TestPad.Common.DTO.Question;

public class QuestionDto
{
    public int Id { get; set; }
    public string Content { get; set; } = default!;
    public ICollection<AnswerDto> Answers { get; set; } = default!;
}