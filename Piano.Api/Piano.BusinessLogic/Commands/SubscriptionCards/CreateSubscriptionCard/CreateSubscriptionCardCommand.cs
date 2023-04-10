using MediatR;
using Piano.BusinessLogic.Models.Cards;

namespace Piano.BusinessLogic.Commands.Subscriptions.CreateSubscriptionCard;

public class CreateSubscriptionCardCommand : IRequest<Unit>
{
    public List<Session> Classes { get; set; }
    public DateTime BuyingDate { get; set; }
    public DateTime ActiveMonth { get; set; }
    public string OwnerId { get; set; }
}