using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TestPad.DAL.Entities;

namespace TestPad.DAL.Context;

public class TestPadContext : IdentityDbContext<User, IdentityRole<int>, int>
{
    public DbSet<Test> Tests { get; private set; }
    public DbSet<Question> Questions { get; private set; }
    public DbSet<Answer> Answers { get; set; }
    
    public TestPadContext(DbContextOptions<TestPadContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Seed();
        base.OnModelCreating(modelBuilder);
    }
}