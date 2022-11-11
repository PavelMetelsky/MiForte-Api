using MediatR;
using Piano.BusinessLogic.Models.Cards;
using Piano.Database;

namespace Piano.BusinessLogic.Commands.Sessions.UpdateSession;

public class UpdateSessionHandler : IRequestHandler<UpdateSessionCommand, Unit>
{
    private readonly PianoContext _pianoContext;

    public UpdateSessionHandler(PianoContext pianoContext)
    {
        _pianoContext = pianoContext;
    }

    public async Task<Unit> Handle(UpdateSessionCommand request, CancellationToken cancellationToken)
    {
        _pianoContext.Sessions.Update(request.Session.ToEntitiesSession());
        await _pianoContext.SaveChangesAsync(cancellationToken);
        return default;
    }
}