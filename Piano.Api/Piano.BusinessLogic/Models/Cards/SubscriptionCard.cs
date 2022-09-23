namespace Piano.BusinessLogic.Models.Cards;

public class SubscriptionCard
{
    public List<Class> Classes { get; set;  } = new();
    public DateOnly BuyingDate { get; set; }
    public DateOnly ActiveMonth { get; set; }
    public int ClassesCount => Classes.Count;
}