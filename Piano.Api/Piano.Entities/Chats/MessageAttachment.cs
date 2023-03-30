namespace Piano.Entities.Chats;

public class MessageAttachment
{
    public Guid Id { get; set; }
    public AttachmentType Type { get; set; }
    public byte[] Data { get; set; }
    public Message Message { get; set; }
}