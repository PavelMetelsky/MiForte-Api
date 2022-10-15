using MediatR;
using Piano.BusinessLogic.Models.Cards;
using Piano.Database;
using SubscriptionCard = Piano.Entities.Subscriptions.SubscriptionCard;

namespace Piano.BusinessLogic.Commands.SubscriptionCards.CreateSubscriptionCard;

public class CreateSubscriptionCardHandler : IRequestHandler<CreateSubscriptionCardCommand, Unit>
{
    private readonly PianoContext _pianoContext;

    public CreateSubscriptionCardHandler(PianoContext pianoContext)
    {
        _pianoContext = pianoContext;
    }

    public async Task<Unit> Handle(CreateSubscriptionCardCommand request, CancellationToken cancellationToken)
    {
        var id = Guid.NewGuid();
        await _pianoContext.SubscriptionCards.AddAsync(new SubscriptionCard
        { 
          ActiveMonth = request.ActiveMonth,
          BuyingDate = request.BuyingDate,
          Sessions = request.Sessions.ToEntitiesSessionList(id),
          OwnerId = Guid.Parse(request.OwnerId),
          MentorId = Guid.Parse(request.MentorId),
          Id = id, 
        }, cancellationToken);
        
        await _pianoContext.SaveChangesAsync(cancellationToken);
        
        return default;
    }
}