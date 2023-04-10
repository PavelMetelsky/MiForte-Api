namespace Piano.Entities.Note;

public class NoteLink
{
    public Guid Id { get; set; }
    public string Link { get; set; }
    public Note Note { get; set; }
}