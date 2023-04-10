using MediatR;
using Piano.Database;
using Piano.Entities;
using Piano.Entities.Subscription;

namespace Piano.BusinessLogic.Commands.Subscriptions.CreateSubscriptionCard;

public class CreateSubscriptionCardHandler : IRequestHandler<CreateSubscriptionCardCommand, Unit>
{
    private readonly PianoContext _pianoContext;

    public CreateSubscriptionCardHandler(PianoContext pianoContext)
    {
        _pianoContext = pianoContext;
    }

    public async Task<Unit> Handle(CreateSubscriptionCardCommand request, CancellationToken cancellationToken)
    {
        return default;
    }
}