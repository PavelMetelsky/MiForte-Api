using MediatR;
using Microsoft.EntityFrameworkCore;
using Piano.BusinessLogic.Models;
using Piano.Database;
using System.Threading.Tasks;

namespace Piano.BusinessLogic.Queries.Users.GetUsers
{
    public class GetUsersHandler : IRequestHandler<GetUsersQuery, List<User>>
    {
        private readonly PianoContext _pianoContext;

        public GetUsersHandler(PianoContext pianoContext)
        {
            _pianoContext = pianoContext;
        }

        public Task<List<User>> Handle(GetUsersQuery request, CancellationToken cancellationToken)
        {
            return default;
        }
    }
}
