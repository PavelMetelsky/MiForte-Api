using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Piano.Entities.Subscriptions;

public class Session
{
    [Key]
    public Guid Id { get; set; }
    public enum SessionState
    {
        WasHeld = 0,
        Postponed = 1,
        Cancelled = 2,
        Upcoming = 4,
    }
    public SessionState State { get; set; } 
    public Guid SubscriptionCardId { get; set; }
    public DateOnly SessionDate { get; set; }
    public TimeSpan Duration { get; set; }
    public Guid OwnerId { get; set; }
}