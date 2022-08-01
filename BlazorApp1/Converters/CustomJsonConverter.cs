using System.Text.Json;
using System.Text.Json.Serialization;

namespace BlazorApp1.Converters
{
    public class CustomJsonConverter : JsonConverter<object>
    {
        public override object? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            // Read to end (doesn't seem to matter though, this isn't required and doesn't make any difference
            // to the memory utilisation).
            while (reader.Read()) { }
            return null;
        }

        public override void Write(Utf8JsonWriter writer, object value, JsonSerializerOptions options)
        {
            throw new NotImplementedException();
        }
    }
}
