using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestPad.DAL.Entities;

namespace TestPad.DAL.Context.EntityConfigurations;

public class TestConfig : IEntityTypeConfiguration<Test>
{
    public void Configure(EntityTypeBuilder<Test> builder)
    {
        builder.HasOne(t => t.Author)
            .WithMany(u => u.Tests)
            .HasForeignKey(t => t.AuthorId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.Property(t => t.Title)
            .HasMaxLength(150);
    }
}