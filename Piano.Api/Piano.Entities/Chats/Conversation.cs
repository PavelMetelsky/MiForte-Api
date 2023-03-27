namespace Piano.Entities.Chats;

public class Conversation
{
    public Guid Id { get; set; }
    public int MessagesCount { get; set; }
    public User First { get; set; }
    public int LastMessageReadByFirstUser { get; set; }
    public User Second { get; set; }
    public int LastMessageReadBySecondUser { get; set; }
    public List<Message> Messages { get; set; }
}