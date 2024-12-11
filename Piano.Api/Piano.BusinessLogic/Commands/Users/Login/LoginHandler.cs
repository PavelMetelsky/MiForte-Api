using MediatR;
using Microsoft.EntityFrameworkCore;
using Piano.Database;

namespace Piano.BusinessLogic.Commands.Users.CreateUser
{
    public class LoginHandler : IRequestHandler<LoginCommand, Result>
    {
        private readonly PianoContext _pianoContext;

        public LoginHandler(PianoContext pianoContext)
        {
            _pianoContext = pianoContext;
        }

        public async Task<Result> Handle(LoginCommand request, CancellationToken cancellationToken)
        {
            return default;
        }
    }
}
