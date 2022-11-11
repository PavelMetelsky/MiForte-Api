using MediatR;
using Piano.BusinessLogic.Models.Cards;

namespace Piano.BusinessLogic.Commands.Sessions.UpdateSession;

public class UpdateSessionCommand : IRequest<Unit>
{
    public Session Session { get; set; }
}