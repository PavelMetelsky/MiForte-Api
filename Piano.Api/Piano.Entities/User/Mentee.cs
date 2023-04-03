namespace Piano.Entities.User;

public class Mentee : User
{
    public Guid MentorId { get; set; }
    public Mentor Mentor { get; set; }
    public List<Subscription.Subscription> Subscriptions;
    public List<Note.Note> Notes;
}