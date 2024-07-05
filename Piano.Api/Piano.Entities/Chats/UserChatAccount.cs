namespace Piano.Entities.Chats;

public class UserChatAccount
{
    public Guid Id { get; set; }
    public TimeOnly AvailableFrom { get; set; }
    public TimeOnly AvailableTo { get; set; }
    public User.User User { get; set; }
}