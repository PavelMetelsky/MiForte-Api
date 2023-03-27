using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Piano.Entities.Mappings
{
    public class SessionMap : IEntityTypeConfiguration<Session>
    {
        public void Configure(EntityTypeBuilder<Session> builder)
        {
            builder.ToTable("Sessions");
            builder.HasKey(s => s.Id)
                   .HasName("Name");

            builder.Property(s => s.Duration)
                   .HasColumnName("Duration")
                   .HasConversion<long>(); // EF has built-in TimeSpan <=> long converter
            builder.Property(s => s.Topic)
                   .HasColumnName("Topic");
            builder.Property(s => s.Status)
                   .HasColumnName("Status")
                   .HasConversion<int>();
            builder.HasOne(s => s.Subscription)
                   .WithMany(s => s.Sessions)
                   .HasForeignKey("SubscriptionId");
            builder.HasOne(s => s.Mentor)
                   .WithMany()
                   .HasForeignKey("MentorId");
            builder.Property(s => s.Commentary)
                   .HasColumnName("Commentary");
            builder.Property(s => s.PlannedDate)
                   .HasColumnName("PlannedDate");
            builder.Property(s => s.ActualDate)
                   .HasColumnName("ActualDate");
            builder.HasMany(s => s.CommentaryLinks)
                   .WithOne(l => l.Session)
                   .OnDelete(DeleteBehavior.Cascade)
                   .HasForeignKey("SessionId");
            builder.HasMany(s => s.Attachments)
                   .WithOne(a => a.Session)
                   .OnDelete(DeleteBehavior.Cascade)
                   .HasForeignKey("SessionId");
        }
    }
}