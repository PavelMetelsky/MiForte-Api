namespace Piano.Entities.Chats;

public class UserChatAccount
{
    public TimeOnly AvailableFrom { get; set; }
    public TimeOnly AvailableTo { get; set; }
    public User User { get; set; }
}