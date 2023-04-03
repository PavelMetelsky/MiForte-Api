using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Piano.Entities.User;

namespace Piano.Entities.Mappings.Users;

public class MenteeMap : IEntityTypeConfiguration<Mentee>
{
    public void Configure(EntityTypeBuilder<Mentee> builder)
    {
        builder.HasBaseType<User.User>();
        builder.ToTable("Students");
        builder.HasMany(s => s.Subscriptions)
               .WithOne(s => s.Mentee)
               .OnDelete(DeleteBehavior.Restrict)
               .HasForeignKey("StudentId");
        builder.HasMany(s => s.Notes)
               .WithOne(n => n.Mentee)
               .OnDelete(DeleteBehavior.Cascade)
               .HasForeignKey("StudentId");
    }
}