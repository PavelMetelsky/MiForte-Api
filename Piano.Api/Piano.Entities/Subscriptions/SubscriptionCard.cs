using System.ComponentModel.DataAnnotations.Schema;

namespace Piano.Entities.Subscriptions;

public class SubscriptionCard
{
    public Guid Id { get; set; }
    public List<Session> Sessions { get; set; } = new();
    public DateOnly BuyingDate { get; set; }
    public DateOnly ActiveMonth { get; set; }
    public Guid OwnerId { get; set; }
    public Guid MentorId { get; set; }
}