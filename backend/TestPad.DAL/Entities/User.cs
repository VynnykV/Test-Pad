using Microsoft.AspNetCore.Identity;

namespace TestPad.DAL.Entities;

public class User : IdentityUser<int>
{
    public ICollection<Test> Tests { get; set; } = default!;
}