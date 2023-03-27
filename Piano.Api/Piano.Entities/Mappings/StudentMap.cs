using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Piano.Entities.Mappings;

public class StudentMap : IEntityTypeConfiguration<Student>
{
    public void Configure(EntityTypeBuilder<Student> builder)
    {
        builder.HasBaseType<User>();
        builder.ToTable("Students");
        builder.HasMany(s => s.Subscriptions)
               .WithOne(s => s.Owner)
               .OnDelete(DeleteBehavior.Cascade)
               .HasForeignKey("StudentId");
        builder.HasMany(s => s.Notes)
               .WithOne(n => n.Student)
               .OnDelete(DeleteBehavior.Cascade)
               .HasForeignKey("StudentId");
    }
}