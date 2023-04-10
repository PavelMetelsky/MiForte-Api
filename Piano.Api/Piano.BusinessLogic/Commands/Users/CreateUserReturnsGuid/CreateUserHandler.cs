using MediatR;
using Piano.Database;

namespace Piano.BusinessLogic.Commands.Users.CreateUser
{
    public class CreateUserHandlerNew : IRequestHandler<CreateUserCommandNew, Result>
    {
        private readonly PianoContext _pianoContext;

        public CreateUserHandlerNew(PianoContext pianoContext)
        {
            _pianoContext = pianoContext;
        }

        public async Task<Result> Handle(CreateUserCommandNew request, CancellationToken cancellationToken)
        {
           

            return default;
        }
    }
}
