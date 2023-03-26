using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Piano.Entities.Mappings
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");
            builder.HasKey(m => m.UserId);

            builder.Property(m => m.UserId).HasColumnName("UserId");
            builder.Property(m => m.Role).HasColumnName("Role");
            builder.Property(m => m.Country).HasColumnName("Country");
            builder.Property(m => m.City).HasColumnName("City");
            builder.Property(m => m.Telephone).HasColumnName("Telephone");
            builder.Property(m => m.Username).HasColumnName("Username");
            builder.Property(m => m.Email).HasColumnName("Email");
            builder.Property(m => m.Password).HasColumnName("Password");
        }
    }
}