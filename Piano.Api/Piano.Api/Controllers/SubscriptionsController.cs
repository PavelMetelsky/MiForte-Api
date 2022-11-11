using MediatR;
using Microsoft.AspNetCore.Mvc;
using Piano.BusinessLogic.Commands.SubscriptionCards.CreateSubscriptionCard;
using Piano.BusinessLogic.Commands.SubscriptionCards.DeleteSubscriptionCard;
using Piano.BusinessLogic.Commands.SubscriptionCards.UpdateSubscriptionCard;
using Piano.BusinessLogic.Queries.SubscriptionCards;

namespace Piano.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SubscriptionsController : ControllerBase
{
    private readonly IMediator _mediator;

    public SubscriptionsController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet("{userId}")]
    public async Task<IActionResult> GetSubscriptionCards(string userId)
    {
        var command = new GetUsersSubscriptionsQuery
        { UserId = userId, };
        return Ok(await _mediator.Send(command));
    }

    [HttpPost]
    public async Task<IActionResult> PostAsync([FromBody] CreateSubscriptionCardCommand command)
    {
        await _mediator.Send(command);
        return Ok();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(string id)
    {
        var command = new DeleteSubscriptionCardCommand
        {
          Id = id,
        };
        await _mediator.Send(command);

        return Ok();
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateSubscriptionCardCommand command)
    {
        await _mediator.Send(command);
        return Ok();
    }
}