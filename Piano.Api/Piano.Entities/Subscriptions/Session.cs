namespace Piano.Entities.Subscriptions;

public class Session
{
    public Guid Id { get; set; }

    public enum SessionState
    {
        WasHeld = 0,
        Postponed = 1,
        Cancelled = 2,
        Upcoming = 4,
    }

    public DateOnly SessionDate { get; set; } // TODO: Rename
    public SessionState State { get; set; }
    public TimeSpan Duration { get; set; }
    public Guid OwnerId { get; set; }
}