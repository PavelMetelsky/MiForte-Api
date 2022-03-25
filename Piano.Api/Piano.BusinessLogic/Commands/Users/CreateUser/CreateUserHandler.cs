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
            var ub = new Entities.UserBuilder();
           await _pianoContext.Users.AddAsync(ub
               .WithUsername(request.Username)
               .HasRole(request.Role)
               .HasEmail(request.Email)
               .HasPassword(request.Password)
               .From(request.Country, request.City)
               .HasTelephoneNumber(request.Telephone)
               .HasSocialLinks(request.SocialLinks)
               .GetUser(), cancellationToken);

            await _pianoContext.SaveChangesAsync(cancellationToken);

            return default;
        }
    }
}
