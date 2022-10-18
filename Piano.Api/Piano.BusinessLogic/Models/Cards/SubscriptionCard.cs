using System.Text.Json.Serialization;
using Piano.BusinessLogic.Converters;

namespace Piano.BusinessLogic.Models.Cards;

public class SubscriptionCard
{
    public Guid Id { get; set; }
    public List<Session> Sessions { get; set; } = new();
    [JsonConverter(typeof(DateOnlyJsonConverter))]
    public DateOnly BuyingDate { get; set; }
    [JsonConverter(typeof(DateOnlyJsonConverter))]
    public DateOnly ActiveMonth { get; set; }
    public Guid OwnerId { get; set; }
    public Guid MentorId { get; set; }
}