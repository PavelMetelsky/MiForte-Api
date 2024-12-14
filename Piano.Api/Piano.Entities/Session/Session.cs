using System.ComponentModel.DataAnnotations.Schema;
using Piano.Entities.User;

namespace Piano.Entities.Session;

public class Session
{
    public Guid Id { get; set; }
    public string Topic { get; set; }
    public TimeSpan Duration { get; set; }
    public SessionStatus Status { get; set; }
    public Subscription.Subscription Subscription { get; set; }
    public Mentor Mentor { get; set; }
    public string Commentary { get; set; }
    public DateTime PlannedDate { get; set; }
    public DateTime? ActualStartTime { get; set; }
    public DateTime? ActualEndTime { get; set; }
    public List<CommentLink> CommentaryLinks { get; set; }
    public List<SessionAttachment> Attachments { get; set; }

    [NotMapped] public bool CanBeChanged => Status is SessionStatus.Planned or SessionStatus.Postponed;

    [NotMapped] public bool CanBeDeleted => Status is SessionStatus.Planned or SessionStatus.Postponed;
}