using MediatR;
using Microsoft.AspNetCore.Mvc;
using Piano.BusinessLogic.Commands.Sessions.AddSession;
using Piano.BusinessLogic.Commands.Sessions.RemoveSession;
using Piano.BusinessLogic.Commands.Sessions.UpdateSession;

namespace Piano.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SessionsController : ControllerBase
{
    private readonly IMediator _mediator;

    public SessionsController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<IActionResult> PostAsync([FromBody] AddSessionCommand command)
    {
        await _mediator.Send(command);
        return Ok();
    }

    [HttpPut]
    public async Task<IActionResult> UpdateAsync([FromBody] UpdateSessionCommand command)
    {
        await _mediator.Send(command);
        return Ok();
    }

    [HttpDelete]
    public async Task<IActionResult> Delete(string id)
    {
        await _mediator.Send(new RemoveSessionCommand
        { Id = id });
        return Ok();
    }
}