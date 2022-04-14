namespace TestPad.DAL.Entities;

public class Test
{
    public int Id { get; set; }
    public string Title { get; set; } = default!;
    public int AuthorId { get; set; }
    public User Author { get; set; } = default!;
    public ICollection<Question> Questions { get; set; } = default!;
}