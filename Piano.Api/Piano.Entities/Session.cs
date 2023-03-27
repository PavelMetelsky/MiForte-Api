namespace Piano.Entities;

public class Session
{
    public enum SessionStatus
    {
        Planned,
        WorkedOut,
        Postponed,
        Frozen,
        Locked
    }
    public Guid Id { get; set; }
    public string Topic { get; set; }
    public TimeSpan Duration { get; set; }
    public SessionStatus Status { get; set; }
    public Subscription Subscription { get; set; }
    public Mentor Mentor { get; set; }
    public string Commentary { get; set; }
    public DateTime PlannedDate { get; set; }
    public DateTime ActualDate { get; set; }
    public List<CommentaryLink> CommentaryLinks { get; set; }
    public List<SessionAttachment> Attachments { get; set; }
}

public class SessionAttachment
{
    public Guid Id { get; set; }
    public AttachmentType Type { get; set; }
    public byte[] Data { get; set; }
    public Session Session { get; set; }
}

public class CommentaryLink
{
    public Guid Id { get; set; }
    public string Link { get; set; }
    public Session Session { get; set; }
}