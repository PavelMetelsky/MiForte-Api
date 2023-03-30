using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Piano.Entities.Note;

namespace Piano.Entities.Mappings;

public class NoteLinkMap : IEntityTypeConfiguration<NoteLink>
{
    public void Configure(EntityTypeBuilder<NoteLink> builder)
    {
        builder.ToTable("NoteLinks");
        builder.HasKey(l => l.Id);

        builder.Property(l => l.Link)
               .HasColumnName("Link");
        builder.HasOne(l => l.Note)
               .WithMany(n => n.Links)
               .OnDelete(DeleteBehavior.Cascade)
               .HasForeignKey("NoteId");
    }
}