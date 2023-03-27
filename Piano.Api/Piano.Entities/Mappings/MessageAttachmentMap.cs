using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Piano.Entities.Chats;

namespace Piano.Entities.Mappings;

public class MessageAttachmentMap : IEntityTypeConfiguration<MessageAttachment>
{
    public void Configure(EntityTypeBuilder<MessageAttachment> builder)
    {
        builder.ToTable("MessageAttachments");
        builder.HasKey(a => a.Id);

        builder.Property(a => a.Type)
               .HasColumnName("Type")
               .HasConversion<int>();
        builder.Property(a => a.Data)
               .HasColumnName("Data");
        builder.HasOne(a => a.Message)
               .WithMany(m => m.Attachments)
               .OnDelete(DeleteBehavior.Cascade)
               .HasForeignKey("MessageId");
    }
}