using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Piano.Entities.Chats;

namespace Piano.Entities.Mappings.Chats;

public class UserChatAccountMap : IEntityTypeConfiguration<UserChatAccount>
{
    public void Configure(EntityTypeBuilder<UserChatAccount> builder)
    {
        builder.ToTable("UserChatAccounts");
        builder.HasKey(a => a.Id);

        builder.Property(u => u.AvailableFrom)
               .HasColumnName("AvailableFrom");
        builder.Property(u => u.AvailableTo)
               .HasColumnName("AvailableTo");
        builder.HasOne(a => a.User)
               .WithOne(u => u.ChatAccount)
               .OnDelete(DeleteBehavior.Cascade)
               .HasForeignKey("UserId");
    }
}