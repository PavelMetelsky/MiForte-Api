using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Piano.Entities.User;

namespace Piano.Entities.Mappings
{
    public class SocialLinkMap : IEntityTypeConfiguration<SocialLink>
    {
        public void Configure(EntityTypeBuilder<SocialLink> builder)
        {
            builder.ToTable("SocialLinks");
            builder.HasKey(m => m.Id);

            builder.HasOne(l => l.User)
                   .WithMany(u => u.SocialLinks)
                   .OnDelete(DeleteBehavior.Cascade)
                   .HasForeignKey("UserId");
            builder.Property(l => l.Link)
                   .HasColumnName("Link");
        }
    }
}