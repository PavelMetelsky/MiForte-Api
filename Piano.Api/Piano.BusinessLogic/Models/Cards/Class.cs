namespace Piano.BusinessLogic.Models.Cards;

public class Class
{
    public DateOnly ClassDate { get; set; }
    public int State { get; set; }
    public TimeSpan Duration { get; set; }
    public Guid MentorId { get; set; }
}