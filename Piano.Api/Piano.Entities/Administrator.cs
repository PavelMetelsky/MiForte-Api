namespace Piano.Entities;

public class Administrator : User.User
{
    public List<Mentor> Mentors { get; set; }
}