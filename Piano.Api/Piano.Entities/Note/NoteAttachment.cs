namespace Piano.Entities.Note;

public class NoteAttachment
{
    public Guid Id { get; set; }
    public AttachmentType Type { get; set; }
    public byte[] Data { get; set; }
    public Note Note { get; set; }
}