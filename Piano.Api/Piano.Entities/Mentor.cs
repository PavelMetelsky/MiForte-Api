namespace Piano.Entities;

public class Mentor : User.User
{
    public List<User.User> Students { get; set; } 
}