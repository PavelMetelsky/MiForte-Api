using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Piano.Entities.Mappings
{
    public class SocialLinkMap : IEntityTypeConfiguration<SocialLink>
    {
        public void Configure(EntityTypeBuilder<SocialLink> builder)
        {
            builder.ToTable("SocialLinks");
            builder.HasKey(m => m.Id);

            builder.Property(m => m.Id).HasColumnName("Id");
            builder.Property(m => m.UserId).HasColumnName("UserId");
            builder.Property(m => m.Link).HasColumnName("Link");
        }
    }
}