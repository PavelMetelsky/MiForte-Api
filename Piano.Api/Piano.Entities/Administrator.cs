namespace Piano.Entities;

public class Administrator : User
{
    public List<Mentor> Mentors { get; set; }
}