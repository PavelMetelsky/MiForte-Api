using Microsoft.EntityFrameworkCore;
using MediatR;
using Piano.BusinessLogic.Models.Cards;
using Piano.Database;

namespace Piano.BusinessLogic.Queries.SubscriptionCards.GetUsersSubscriptions;

public class GetUsersSubscriptionsHandler : IRequestHandler<GetUsersSubscriptionsQuery, List<SubscriptionCard>>
{
    private readonly PianoContext _pianoContext;

    public GetUsersSubscriptionsHandler(PianoContext pianoContext)
    {
        _pianoContext = pianoContext;
    }

    public async Task<List<SubscriptionCard>> Handle(GetUsersSubscriptionsQuery request,
        CancellationToken cancellationToken)
    {
        var userGuid = Guid.Parse(request.UserId);
        return await _pianoContext.SubscriptionCards
                                  .Where(s => s.OwnerId == userGuid)
                                  .Select(s => s.ToModelSubscriptionCard())
                                  .ToListAsync(cancellationToken);
    }
}