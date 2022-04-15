namespace TestPad.Common.DTO.Answer;

public class AnswerDto
{
    public int Id { get; set; }
    public string Content { get; set; } = default!;
    public bool IsCorrect { get; set; }
}