using MediatR;
using Piano.Database;

namespace Piano.BusinessLogic.Commands.Users.CreateUser
{
    public class CreateUserHandler : IRequestHandler<CreateUserCommand, Unit>
    {
        private readonly PianoContext _pianoContext;

        public CreateUserHandler(PianoContext pianoContext)
        {
            _pianoContext = pianoContext;
        }

        public async Task<Unit> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            return default;
        }
    }
}
