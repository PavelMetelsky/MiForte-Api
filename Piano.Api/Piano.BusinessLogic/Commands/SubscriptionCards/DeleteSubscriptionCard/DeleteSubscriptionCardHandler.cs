using MediatR;
using Piano.Database;
using Piano.Entities.Subscriptions;

namespace Piano.BusinessLogic.Commands.SubscriptionCards.DeleteSubscriptionCard;

public class DeleteSubscriptionCardHandler : IRequestHandler<DeleteSubscriptionCardCommand, Unit>
{
    private readonly PianoContext _pianoContext;

    public DeleteSubscriptionCardHandler(PianoContext pianoContext)
    {
        _pianoContext = pianoContext;
    }

    public async Task<Unit> Handle(DeleteSubscriptionCardCommand request, CancellationToken cancellationToken)
    {
        var id = Guid.Parse(request.Id);
        SubscriptionCard? entity = _pianoContext.SubscriptionCards.SingleOrDefault(s => s.Id == id);
        if (entity == null)
        {
            return default;
        }

        _pianoContext.SubscriptionCards.Remove(entity);
        await _pianoContext.SaveChangesAsync(cancellationToken);
        return default;
    }
}