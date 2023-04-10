using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Piano.Entities.Subscription;

namespace Piano.Entities.Mappings.Subscriptions;

public class MonthlySubscriptionMap : IEntityTypeConfiguration<MonthlySubscription>
{
    public void Configure(EntityTypeBuilder<MonthlySubscription> builder)
    {
        builder.ToTable("MonthlySubscriptions");
        builder.HasBaseType<Subscription.Subscription>();

        builder.Property(s => s.StartDate)
               .HasColumnName("StartDate");
        builder.Property(s => s.EndDate)
               .HasColumnName("EndDate");
        builder.Property(s => s.NumberOfSessions)
               .HasColumnName("NumberOfSessions");
    }
}