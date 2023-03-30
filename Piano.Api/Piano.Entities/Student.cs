namespace Piano.Entities;

public class Student : User.User
{
    public List<Subscription> Subscriptions;
    public List<Note.Note> Notes;
}