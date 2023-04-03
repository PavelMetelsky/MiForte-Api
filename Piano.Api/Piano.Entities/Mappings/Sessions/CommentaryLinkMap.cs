using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Piano.Entities.Session;

namespace Piano.Entities.Mappings.Sessions;

public class CommentaryLinkMap : IEntityTypeConfiguration<CommentaryLink>
{
    public void Configure(EntityTypeBuilder<CommentaryLink> builder)
    {
        builder.ToTable("SessionCommentaryLinks");
        builder.HasKey(l => l.Id);
        builder.Property(l => l.Link)
               .HasColumnName("Link");
        builder.HasOne(l => l.Session)
               .WithMany(s => s.CommentaryLinks)
               .OnDelete(DeleteBehavior.Cascade)
               .HasForeignKey("SessionId");
    }
}