namespace TestPad.DAL.Entities;

public class Question
{
    public int Id { get; set; }
    public string Content { get; set; } = default!;
    public int TestId { get; set; }
    public Test Test { get; set; } = default!;
    public ICollection<Answer> Answers { get; set; } = default!;
}