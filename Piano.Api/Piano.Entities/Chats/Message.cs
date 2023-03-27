namespace Piano.Entities.Chats;

public class Message
{
    public Guid Id { get; set; }
    public DateTime SendingTime { get; set; }
    public Conversation Conversation { get; set; }
    public List<MessageAttachment> Attachments { get; set; }
}

public class MessageAttachment
{
    public Guid Id { get; set; }
    public AttachmentType Type { get; set; }
    public byte[] Data { get; set; }
    public Message Message { get; set; }
}