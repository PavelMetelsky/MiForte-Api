using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Piano.Entities.Subscriptions;

namespace Piano.Entities.Mappings
{
    public class SessionMap : IEntityTypeConfiguration<Session>
    {
        public void Configure(EntityTypeBuilder<Session> builder)
        {
            builder.ToTable("Sessions");
            builder.HasKey(m => m.SessionId);

            builder.Property(m => m.SessionId).HasColumnName("SessionId");
            builder.Property(m => m.ClassDate).HasColumnName("ClassDate");
            builder.Property(m => m.State).HasColumnName("State");
            builder.Property(m => m.Duration).HasColumnName("Duration");
        }
    }
}