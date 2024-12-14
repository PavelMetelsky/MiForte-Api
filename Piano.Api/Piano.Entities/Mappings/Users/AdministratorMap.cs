using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Piano.Entities.User;

namespace Piano.Entities.Mappings.Users;

public class AdministratorMap : IEntityTypeConfiguration<Admin>
{
    public void Configure(EntityTypeBuilder<Admin> builder)
    {
        builder.HasBaseType<User.User>();
        builder.ToTable("Administrators");
    }
}