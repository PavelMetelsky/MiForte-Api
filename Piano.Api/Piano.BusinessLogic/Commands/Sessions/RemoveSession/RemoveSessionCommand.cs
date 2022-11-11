using MediatR;

namespace Piano.BusinessLogic.Commands.Sessions.RemoveSession;

public class RemoveSessionCommand : IRequest<Unit>
{
    public string Id { get; set; }
}