using MediatR;
using Piano.BusinessLogic.Models.Cards;

namespace Piano.BusinessLogic.Commands.SubscriptionCards.UpdateSubscriptionCard;

public class UpdateSubscriptionCardCommand : IRequest<Unit>
{
    public SubscriptionCard SubscriptionCard { get; set; }
}