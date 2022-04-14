namespace TestPad.DAL.Entities;

public class Answer
{
    public int Id { get; set; }
    public string Content { get; set; } = default!;
    public bool IsCorrect { get; set; }
    public bool IsRequired { get; set; }
    public int QuestionId { get; set; }
    public Question Question { get; set; } = default!;
}