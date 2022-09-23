using System.Runtime.CompilerServices;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Piano.Entities.Subscriptions;

public class SubscriptionCard
{
    public List<Class> Classes { get; set;  } = new();
    public DateOnly BuyingDate { get; set; }
    public DateOnly ActiveMonth { get; set; }
    public User Owner { get; set; }
    public int ClassesCount => Classes.Count;
}