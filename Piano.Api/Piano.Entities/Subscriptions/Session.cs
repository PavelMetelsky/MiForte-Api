namespace Piano.Entities.Subscriptions;

public class Session
{
    public enum SessionState
    {
        WasHeld = 0,
        Postponed = 1,
        Cancelled = 2,
        Upcoming = 4,
    }
    public DateOnly ClassDate { get; set; }
    public SessionState State { get; set; }
    public TimeSpan Duration { get; set; }
    public Guid MentorId { get; set; }
}