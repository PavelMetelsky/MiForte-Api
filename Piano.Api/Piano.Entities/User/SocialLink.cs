namespace Piano.Entities.User;

public class SocialLink
{
    public Guid Id { get; set; }
    public Entities.User.User User { get; set; }
    public string Link { get; set; }
}