using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Piano.Entities.Mappings;

public class MentorMap : IEntityTypeConfiguration<Mentor>
{
    public void Configure(EntityTypeBuilder<Mentor> builder)
    {
        builder.HasBaseType<User.User>();
        builder.ToTable("Mentors");
        builder.HasMany(m => m.Students)
               .WithOne()
               .HasForeignKey("MentorId")
               .OnDelete(DeleteBehavior.Cascade);
    }
}