using MediatR;
using Piano.BusinessLogic.Models.Cards;

namespace Piano.BusinessLogic.Commands.SubscriptionCards.CreateSubscriptionCard;

public class CreateSubscriptionCardCommand : IRequest<Unit>
{
    public List<Session> Classes { get; set; }
    public DateOnly BuyingDate { get; set; }
    public DateOnly ActiveMonth { get; set; }
    public string OwnerId { get; set; }
    public string MentorId { get; set; }
}