namespace Piano.Entities;

public class Note
{
    public Guid Id { get; set; }
    public Student Student { get; set; }
    public Mentor Mentor { get; set; }
    public string SessionTopic { get; set; }
    public string Text { get; set; }
    public List<NoteLink> Links { get; set; }
    public List<NoteAttachment> Attachments { get; set; }
}

public class NoteLink
{
    public Guid Id { get; set; }
    public string Link { get; set; }
    public Note Note { get; set; }
}

public class NoteAttachment
{
    public Guid Id { get; set; }
    public AttachmentType Type { get; set; }
    public byte[] Data { get; set; }
    public Note Note { get; set; }
}