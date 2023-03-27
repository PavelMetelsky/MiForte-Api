namespace Piano.Entities;

public class Mentor : User
{
    public List<User> Students { get; set; } 
}