using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Piano.Entities.User;

namespace Piano.Entities.Mappings.Users;

public class MentorMap : IEntityTypeConfiguration<Mentor>
{
    public void Configure(EntityTypeBuilder<Mentor> builder)
    {
        builder.HasBaseType<User.User>();
        builder.ToTable("Mentors");
        builder.HasMany(m => m.Mentees)
               .WithOne()
               .HasForeignKey("MentorId")
               .OnDelete(DeleteBehavior.Restrict);
    }
}