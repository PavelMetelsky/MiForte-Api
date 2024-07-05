using Piano.BusinessLogic.Models.Cards;

namespace Piano.BusinessLogic.Queries.Subscriptions;

public class GetUsersSubscriptionsResponse
{
    public List<SubscriptionCard> SubscriptionsList { get; set; }
}