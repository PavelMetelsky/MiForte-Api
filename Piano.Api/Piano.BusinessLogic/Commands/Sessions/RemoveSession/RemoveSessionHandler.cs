using MediatR;
using Microsoft.EntityFrameworkCore;
using Piano.Database;
using Piano.Entities.Subscriptions;

namespace Piano.BusinessLogic.Commands.Sessions.RemoveSession;

public class RemoveSessionHandler : IRequestHandler<RemoveSessionCommand, Unit>
{
    private readonly PianoContext _pianoContext;

    public RemoveSessionHandler(PianoContext pianoContext)
    {
        _pianoContext = pianoContext;
    }

    public async Task<Unit> Handle(RemoveSessionCommand request, CancellationToken cancellationToken)
    {
        var id = Guid.Parse(request.Id);
        Session? entity = await _pianoContext.Sessions.FirstOrDefaultAsync(i => i.Id == id, cancellationToken);
        if (entity is null)
        {
            return default;
        }

        _pianoContext.Sessions.Remove(entity);
        await _pianoContext.SaveChangesAsync(cancellationToken);
        return default;
    }
}