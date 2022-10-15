using MediatR;

namespace Piano.BusinessLogic.Commands.SubscriptionCards.DeleteSubscriptionCard;

public class DeleteSubscriptionCardCommand : IRequest<Unit>
{
    public string Id { get; set; }
}