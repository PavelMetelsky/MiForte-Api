using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Piano.Entities.Subscriptions;

namespace Piano.Entities.Mappings
{
    public class SubscriptionCardMap : IEntityTypeConfiguration<SubscriptionCard>
    {
        public void Configure(EntityTypeBuilder<SubscriptionCard> builder)
        {
            builder.ToTable("SubscriptionCards");
            builder.HasKey(m => m.Id);

            builder.Property(m => m.Id).HasColumnName("Id");
            builder.Property(m => m.BuyingDate).HasColumnName("BuyingDate");
            builder.Property(m => m.ActiveMonth).HasColumnName("ActiveMonth");
        }
    }
}