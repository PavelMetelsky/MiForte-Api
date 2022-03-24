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
           await _pianoContext.Users.AddAsync(new Entities.User
            {
                Email = request.Email,
                Username = request.Username,
                Password = request.Password,
                UserId = Guid.NewGuid(),
                Country = request.Country,
                City = request.City,
                Telephone = request.Telephone,
                Role = request.Role
            }, cancellationToken);

            await _pianoContext.SaveChangesAsync(cancellationToken);

            return default;
        }
    }
}
