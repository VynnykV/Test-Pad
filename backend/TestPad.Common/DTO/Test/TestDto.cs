using TestPad.Common.DTO.Question;

namespace TestPad.Common.DTO.Test;

public class TestDto
{
    public int Id { get; set; }
    public string Title { get; set; } = default!;
    public string Description { get; set; } = default!;
    public ICollection<QuestionDto> Questions { get; set; } = default!;
}