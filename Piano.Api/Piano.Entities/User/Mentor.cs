namespace Piano.Entities.User;

public class Mentor : User
{
    public List<User> Mentees { get; set; } 
}