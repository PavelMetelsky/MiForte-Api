using System.ComponentModel.DataAnnotations.Schema;
using Piano.Entities.User;

namespace Piano.Entities.Subscription;

public abstract class Subscription
{
    public Guid Id { get; set; }
    public Mentee Mentee { get; set; }
    public SubscriptionStatus Status { get; set; }
    public List<Session.Session> Sessions { get; set; }
    [NotMapped] public abstract Range<DateOnly> SubscriptionPeriod { get; }

    public abstract bool CanAddSession(Session.Session session);
}