using MediatR;
using Piano.BusinessLogic.Models.Cards;
using Piano.Database;

namespace Piano.BusinessLogic.Commands.SubscriptionCards.UpdateSubscriptionCard;

public class UpdateSubscriptionCardHandler : IRequestHandler<UpdateSubscriptionCardCommand, Unit>
{
    private readonly PianoContext _pianoContext;

    public UpdateSubscriptionCardHandler(PianoContext pianoContext)
    {
        _pianoContext = pianoContext;
    }

    public async Task<Unit> Handle(UpdateSubscriptionCardCommand request, CancellationToken cancellationToken)
    {
        var card = request.SubscriptionCard.ToEntitiesSubscriptionCard();
        _pianoContext.Update(card);
        await _pianoContext.SaveChangesAsync(cancellationToken);
        return default;
    }
}