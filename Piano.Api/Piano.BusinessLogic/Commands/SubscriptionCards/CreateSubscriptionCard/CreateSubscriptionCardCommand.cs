using System.Text.Json.Serialization;
using MediatR;
using Piano.BusinessLogic.Converters;
using Piano.BusinessLogic.Models.Cards;

namespace Piano.BusinessLogic.Commands.SubscriptionCards.CreateSubscriptionCard;

public class CreateSubscriptionCardCommand : IRequest<Unit>
{
    public List<RequestSession> Classes { get; set; }
    [JsonConverter(typeof(DateOnlyJsonConverter))]
    public DateOnly BuyingDate { get; set; }
    [JsonConverter(typeof(DateOnlyJsonConverter))]
    public DateOnly ActiveMonth { get; set; }
    public string OwnerId { get; set; }
    public string MentorId { get; set; }
}
public class RequestSession
{
    [JsonConverter(typeof(DateOnlyJsonConverter))]
    public DateOnly SessionDate { get; set; }
    public int State { get; set; }
    [JsonConverter(typeof(TimeSpanJsonConverter))]
    public TimeSpan Duration { get; set; }
    public Guid OwnerId { get; set; }
}