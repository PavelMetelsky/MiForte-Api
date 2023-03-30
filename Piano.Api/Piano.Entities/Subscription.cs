namespace Piano.Entities;

public class Subscription
{
    public enum SubscriptionStatus
    {
        Active,
        WorkedOut,
        Frozen
    }
    public Guid Id { get; set; }
    public Student Owner { get; set; }
    public DateOnly Month { get; set; }
    public SubscriptionStatus Status { get; set; }
    public List<Session.Session> Sessions { get; set; }
    public int NumberOfSessions { get; set; }
}