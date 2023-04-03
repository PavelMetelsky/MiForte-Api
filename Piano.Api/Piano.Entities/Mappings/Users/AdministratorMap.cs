using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Piano.Entities.User;

namespace Piano.Entities.Mappings.Users;

public class AdministratorMap : IEntityTypeConfiguration<Administrator>
{
    public void Configure(EntityTypeBuilder<Administrator> builder)
    {
        builder.HasBaseType<User.User>();
        builder.ToTable("Administrators");
    }
}