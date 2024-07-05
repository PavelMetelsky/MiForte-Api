using MediatR;
using Piano.Database;
using Piano.Entities;
using Piano.Entities.Subscription;

namespace Piano.BusinessLogic.Commands.Subscriptions.DeleteSubscriptionCard;

public class DeleteSubscriptionCardHandler : IRequestHandler<DeleteSubscriptionCardCommand, Unit>
{
    private readonly PianoContext _pianoContext;

    public DeleteSubscriptionCardHandler(PianoContext pianoContext)
    {
        _pianoContext = pianoContext;
    }

    public async Task<Unit> Handle(DeleteSubscriptionCardCommand request, CancellationToken cancellationToken)
    {
        var entity = await _pianoContext.FindAsync<Subscription>(request.Id);
        if (entity is not null)
            _pianoContext.Subscriptions.Remove(entity);

        return default;
    }
}