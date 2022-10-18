using System.Text.Json.Serialization;
using Piano.BusinessLogic.Converters;

namespace Piano.BusinessLogic.Models.Cards;

public class Session
{
    public Guid Id { get; set; }
    [JsonConverter(typeof(DateOnlyJsonConverter))]
    public DateOnly SessionDate { get; set; }
    public int State { get; set; }
    [JsonConverter(typeof(TimeSpanJsonConverter))]
    public TimeSpan Duration { get; set; }
    public Guid OwnerId { get; set; }
    public Guid SubscriptionCardId { get; set; }
}