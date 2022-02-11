using MediatR;
using Piano.BusinessLogic.Models;
using System.ComponentModel.DataAnnotations;

namespace Piano.BusinessLogic.Commands.Users.CreateUser
{
    public class CreateUserCommand : IRequest<Unit>
    {
        [Required]
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
