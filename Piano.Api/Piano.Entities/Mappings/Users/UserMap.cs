using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Piano.Entities.Mappings.Users
{
    public class UserMap : IEntityTypeConfiguration<User.User>
    {
        public void Configure(EntityTypeBuilder<User.User> builder)
        {
            builder.ToTable("Users");
            builder.HasKey(m => m.Id);

            builder.Property(u => u.Login)
                   .HasColumnName("Login");
            builder.Property(u => u.Password)
                   .HasColumnName("Password");
            builder.Property(u => u.PhoneNumber)
                   .HasColumnName("PhoneNumber");
            builder.Property(u => u.Email)
                   .HasColumnName("Email");
            builder.Property(u => u.Country)
                   .HasColumnName("Country");
            builder.Property(u => u.City)
                   .HasColumnName("City");
            builder.Property(u => u.IsDeleted)
                   .HasColumnName("IsDeleted");
            builder.Property(u => u.IsActive)
                   .HasColumnName("IsActive");
            builder.Property(u => u.ApprovedBy)
                   .HasColumnName("ApprovedBy");
            builder.HasMany(u => u.SocialLinks)
                   .WithOne(l => l.User)
                   .OnDelete(DeleteBehavior.Cascade)
                   .HasForeignKey("UserId");
        }
    }
}