using System.Text.Json;
using System.Text.Json.Serialization;

namespace ExceptionHandler.Exceptions;

public class InternalErrorJsonConverter : JsonConverter<InternalError>
{
    public override InternalError Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        throw new NotImplementedException();
    }

    public override void Write(Utf8JsonWriter writer, InternalError value, JsonSerializerOptions options)
    {
        var internalError = new
        {
            value.StatusCode,
            value.Message
        };

        JsonSerializer.Serialize(writer, internalError, options);
    }
}
