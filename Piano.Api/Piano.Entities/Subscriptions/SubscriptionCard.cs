using System.Runtime.CompilerServices;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Piano.Entities.Subscriptions;

public class SubscriptionCard
{
    public Guid Id { get; set; }
    public List<Session> Sessions { get; set;  } = new();
    public DateOnly BuyingDate { get; set; }
    public DateOnly ActiveMonth { get; set; }
    public Guid OwnerId { get; set; }
    public int ClassesCount => Sessions.Count;
}