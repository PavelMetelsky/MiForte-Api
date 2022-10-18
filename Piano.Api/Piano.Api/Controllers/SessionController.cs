using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Piano.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SessionController
{
    private readonly IMediator _mediator;

    public SessionController(IMediator mediator)
    {
        _mediator = mediator;
    }
}