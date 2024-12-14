using Piano.Entities.User;

namespace Piano.Entities.Note;

public class Note
{
    public Guid Id { get; set; }
    public Mentee Mentee { get; set; }
    public Mentor Mentor { get; set; }
    public string SessionTopic { get; set; }
    public string Text { get; set; }
    public List<NoteLink> Links { get; set; }
    public List<NoteAttachment> Attachments { get; set; }
    public int MenteeId { get; set; }
}