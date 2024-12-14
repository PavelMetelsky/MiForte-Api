namespace Piano.Entities.Session;

public class CommentLink
{
    public Guid Id { get; set; }
    public string Link { get; set; }
    public Session Session { get; set; }
}