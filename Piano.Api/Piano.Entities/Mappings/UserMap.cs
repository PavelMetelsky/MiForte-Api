﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Piano.Entities.Mappings
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");
            builder.HasKey(m => m.Id);

            builder.Property(u => u.UserType)
                   .HasColumnName("UserType")
                   .HasConversion<int>();
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
            builder.HasMany(u => u.SocialLinks)
                   .WithOne(l => l.User)
                   .OnDelete(DeleteBehavior.Cascade)
                   .HasForeignKey("UserId");
            builder.HasOne(u => u.ChatAccount)
                   .WithOne(a => a.User)
                   .OnDelete(DeleteBehavior.Cascade)
                   .HasForeignKey("AccountId");
        }
    }
}