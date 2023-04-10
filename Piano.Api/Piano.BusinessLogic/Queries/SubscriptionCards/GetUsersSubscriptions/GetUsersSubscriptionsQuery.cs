using MediatR;
using Piano.BusinessLogic.Models.Cards;

namespace Piano.BusinessLogic.Queries.Subscriptions;

public class GetUsersSubscriptionsQuery : IRequest<List<SubscriptionCard>>
{
    public string UserId { get; set; }
}