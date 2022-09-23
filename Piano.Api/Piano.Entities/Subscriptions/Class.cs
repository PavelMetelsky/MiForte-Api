namespace Piano.Entities.Subscriptions;

public class Class
{
    public enum ClassState
    {
        WasHeld = 0,
        Postponed = 1,
        Cancelled = 2,
        Upcoming = 4,
    }
    public DateOnly ClassDate { get; set; }
    public ClassState State { get; set; }
    public TimeSpan Duration { get; set; }
    public User Mentor { get; set; }
}