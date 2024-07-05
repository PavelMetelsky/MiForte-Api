using System.Data.Entity;
using MediatR;
using Piano.BusinessLogic.Models.Cards;
using Piano.Database;

namespace Piano.BusinessLogic.Queries.Subscriptions;

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
        return default;
    }
}