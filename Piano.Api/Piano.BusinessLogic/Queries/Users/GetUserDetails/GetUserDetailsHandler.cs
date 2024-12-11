using MediatR;
using Microsoft.EntityFrameworkCore;
using Piano.BusinessLogic.Models;
using Piano.Database;

namespace Piano.BusinessLogic.Queries.Users.GetUserDetails
{
    public class GetUserDetailsHandler : IRequestHandler<GetUserDetailsQuery, UserModel>
    {
        private readonly PianoContext _pianoContext;

        public GetUserDetailsHandler(PianoContext pianoContext)
        {
            _pianoContext = pianoContext;
        }

        public async Task<UserModel> Handle(GetUserDetailsQuery request, CancellationToken cancellationToken)
        {
            return default;
        }
    }
}
