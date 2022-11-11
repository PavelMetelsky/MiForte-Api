using MediatR;
using Piano.BusinessLogic.Models.Cards;

namespace Piano.BusinessLogic.Commands.Sessions.AddSession;

public class AddSessionCommand : IRequest<Unit>
{
    public DateOnly SessionDate { get; set; }
    public int State { get; set; }
    public TimeSpan Duration { get; set; }
    public Guid OwnerId { get; set; }
    public Guid SubscriptionCardId { get; set; }

    public Session ToSession()
    {
        return new Session
        { 
          SessionDate = SessionDate,
          State = State,
          Duration = Duration,
          OwnerId = OwnerId,
          SubscriptionCardId = SubscriptionCardId,
          Id = Guid.NewGuid()
        };
    }
}