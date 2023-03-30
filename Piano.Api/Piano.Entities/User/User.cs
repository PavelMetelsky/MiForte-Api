using Piano.Entities.Chats;

namespace Piano.Entities.User;

public class User
{
    public enum Type
    {
        User,
        Mentor,
        Administrator
    }
    public Guid Id { get; set; }
    public Type UserType { get; set; }
    public string Login { get; set; }
    public string Password { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public string Country { get; set; }
    public string City { get; set; }
    public List<SocialLink> SocialLinks { get; set; }
    public UserChatAccount ChatAccount { get; set; }
}