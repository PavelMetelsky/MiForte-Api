namespace Piano.BusinessLogic.Models.Cards;

public class Session
{
    public Guid Id { get; set; }
    public DateOnly SessionDate { get; set; }
    public int State { get; set; }
    public TimeSpan Duration { get; set; }
    public Guid OwnerId { get; set; }
}