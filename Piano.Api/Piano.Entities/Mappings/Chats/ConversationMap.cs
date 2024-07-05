using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Piano.Entities.Chats;

namespace Piano.Entities.Mappings.Chats;

public class ConversationMap : IEntityTypeConfiguration<Conversation>
{
    public void Configure(EntityTypeBuilder<Conversation> builder)
    {
        builder.ToTable("Conversations");
        builder.HasKey(c => c.Id);

        builder.Property(c => c.MessagesCount)
               .HasColumnName("MessagesCount");
        builder.HasOne(c => c.First)
               .WithMany()
               .OnDelete(DeleteBehavior.NoAction)
               .HasForeignKey("FirstUserId");
        builder.Property(c => c.LastMessageReadByFirstUser)
               .HasColumnName("LastMessageReadByFirstUser");
        builder.HasOne(c => c.Second)
               .WithMany()
               .OnDelete(DeleteBehavior.NoAction)
               .HasForeignKey("SecondUserId");
        builder.Property(c => c.LastMessageReadBySecondUser)
               .HasColumnName("LastMessageReadBySecondUser");
        builder.HasMany(c => c.Messages)
               .WithOne(m => m.Conversation)
               .OnDelete(DeleteBehavior.Cascade)
               .HasForeignKey("ConversationId");
    }
}