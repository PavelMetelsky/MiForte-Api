using MediatR;

namespace Piano.BusinessLogic.Commands.Subscriptions.DeleteSubscriptionCard;

public class DeleteSubscriptionCardCommand : IRequest<Unit>
{
    public Guid Id { get; set; }
}