using MediatR;
using Piano.BusinessLogic.Models.Cards;
using Piano.Database;

namespace Piano.BusinessLogic.Commands.Sessions.AddSession;

public class AddSessionHandler : IRequestHandler<AddSessionCommand, Unit>
{
    private readonly PianoContext _pianoContext;

    public AddSessionHandler(PianoContext pianoContext)
    {
        _pianoContext = pianoContext;
    }

    public async Task<Unit> Handle(AddSessionCommand request, CancellationToken cancellationToken)
    {
        await _pianoContext.AddAsync(request.ToSession().ToEntitiesSession(), cancellationToken);
        await _pianoContext.SaveChangesAsync(cancellationToken);
        return default;
    }
}