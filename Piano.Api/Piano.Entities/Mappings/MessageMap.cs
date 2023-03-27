using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Piano.Entities.Chats;

namespace Piano.Entities.Mappings;

public class MessageMap : IEntityTypeConfiguration<Message>
{
    public void Configure(EntityTypeBuilder<Message> builder)
    {
        builder.ToTable("Messages");
        builder.HasKey(m => m.Id);

        builder.Property(m => m.SendingTime)
               .HasColumnName("SendingTime");
        builder.HasOne(m => m.Conversation)
               .WithMany(c => c.Messages)
               .HasForeignKey("ConversationId");
        builder.HasMany(m => m.Attachments)
               .WithOne(a => a.Message)
               .OnDelete(DeleteBehavior.Cascade)
               .HasForeignKey("MessageId");
    }
}