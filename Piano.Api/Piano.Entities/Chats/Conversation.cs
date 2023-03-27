namespace Piano.Entities.Chats;

public class Conversation
{
    public int MessagesCount { get; set; }
    public User First { get; set; }
    public int LastMessageReadByFirstUser { get; set; }
    public User Second { get; set; }
    public int LastMessageReadBySecondUser { get; set; }
}