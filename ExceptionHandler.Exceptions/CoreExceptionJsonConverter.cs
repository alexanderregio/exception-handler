using System.Text.Json;
using System.Text.Json.Serialization;

namespace ExceptionHandler.Exceptions;

public class CoreExceptionJsonConverter : JsonConverter<CoreException>
{
    public override CoreException Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        throw new NotImplementedException();
    }

    public override void Write(Utf8JsonWriter writer, CoreException value, JsonSerializerOptions options)
    {
        var coreException = new
        {
            value.Key,
            Erros = value.Errors.Select(c => new { c.Key, c.Message })
        };

        JsonSerializer.Serialize(writer, coreException, options);
    }
}
