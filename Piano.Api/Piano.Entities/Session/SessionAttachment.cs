namespace Piano.Entities.Session;

public class SessionAttachment
{
    public Guid Id { get; set; }
    public AttachmentType Type { get; set; }
    public byte[] Data { get; set; }
    public Session Session { get; set; }
}