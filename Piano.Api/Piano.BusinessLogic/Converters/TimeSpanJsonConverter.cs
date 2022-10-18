using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Piano.BusinessLogic.Converters;

public class TimeSpanJsonConverter : JsonConverter<TimeSpan>
{
    private string Format = "h\\:mm";
    public override TimeSpan Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var s = reader.GetString()!;
        return TimeSpan.ParseExact(s, Format, CultureInfo.InvariantCulture);
    }

    public override void Write(Utf8JsonWriter writer, TimeSpan value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(value.ToString(Format, CultureInfo.InvariantCulture));
    }
}