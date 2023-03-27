using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Piano.Entities.Mappings;

public class AdministratorMap : IEntityTypeConfiguration<Administrator>
{
    public void Configure(EntityTypeBuilder<Administrator> builder)
    {
        builder.HasBaseType<User>();
        builder.ToTable("Administrators");
        builder.HasMany(a => a.Mentors)
               .WithOne()
               .OnDelete(DeleteBehavior.Restrict)
               .HasForeignKey("AdministratorId");
    }
}