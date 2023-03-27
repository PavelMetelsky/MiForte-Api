namespace Piano.Entities;

public class SocialLink
{
    public Guid Id { get; set; }
    public User User { get; set; }
    public string Link { get; set; }
}