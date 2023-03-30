using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Piano.Entities.Note;

namespace Piano.Entities.Mappings;

public class NoteAttachmentMap : IEntityTypeConfiguration<NoteAttachment>
{
    public void Configure(EntityTypeBuilder<NoteAttachment> builder)
    {
        builder.ToTable("NoteAttachments");
        builder.HasKey(a => a.Id);

        builder.Property(a => a.Type)
               .HasColumnName("Type")
               .HasConversion<int>();
        builder.Property(a => a.Data)
               .HasColumnName("Data");
        builder.HasOne(a => a.Note)
               .WithMany(n => n.Attachments)
               .OnDelete(DeleteBehavior.Cascade)
               .HasForeignKey("NoteId");
    }
}