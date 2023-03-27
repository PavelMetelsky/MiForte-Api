using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Piano.Entities.Mappings
{
    public class SubscriptionMap : IEntityTypeConfiguration<Subscription>
    {
        /// <summary>
        /// Converts <see cref="DateOnly" /> to <see cref="DateTime"/> and vice versa.
        /// </summary>
        public class DateOnlyConverter : ValueConverter<DateOnly, DateTime>
        {
            /// <summary>
            /// Creates a new instance of this converter.
            /// </summary>
            public DateOnlyConverter() : base(
                d => d.ToDateTime(TimeOnly.MinValue),
                d => DateOnly.FromDateTime(d))
            { }
        }
        
        public void Configure(EntityTypeBuilder<Subscription> builder)
        {
            builder.ToTable("Subscriptions");
            builder.HasKey(m => m.Id);
            builder.HasOne(s => s.Owner)
                   .WithMany(o => o.Subscriptions)
                   .OnDelete(DeleteBehavior.Cascade)
                   .HasForeignKey("StudentId");
            builder.Property(s => s.Month)
                   .HasColumnName("Month")
                   .HasConversion<DateOnlyConverter>();
            builder.Property(s => s.Status)
                   .HasConversion<int>()
                   .HasColumnName("Status");
            builder.HasMany(s => s.Sessions)
                   .WithOne(s => s.Subscription)
                   .OnDelete(DeleteBehavior.Cascade)
                   .HasForeignKey("SubscriptionId");
            builder.Property(s => s.NumberOfSessions)
                   .HasColumnName("NumberOfSessions");
        }
        
    }
    
    
}