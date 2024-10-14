namespace DriveToGetDataWebsitePrototype.Services
{
    using DriveToGetDataWebsitePrototype.Models;
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    public class SpecialTimeConverter : JsonConverter<Time>
    {
        public override Time Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType != JsonTokenType.StartObject)
            {
                throw new JsonException("Expected StartObject token type.");
            }

            var time = new Time();
            while (reader.Read())
            {
                if (reader.TokenType == JsonTokenType.EndObject)
                {
                    return time;
                }

                if (reader.TokenType == JsonTokenType.PropertyName)
                {
                    string propertyName = reader.GetString();
                    reader.Read();

                    if (propertyName == "millis")
                    {
                        time.Millis = reader.GetString();  // Read the millis value
                    }
                    else if (propertyName == "time")
                    {
                        time.TimeValue = reader.GetString();  // Read the time value
                    }
                }
            }

            throw new JsonException("Expected EndObject token type.");
        }

        public override void Write(Utf8JsonWriter writer, Time value, JsonSerializerOptions options)
        {
            writer.WriteStartObject();
            writer.WriteString("millis", value.Millis);
            writer.WriteString("time", value.TimeValue);
            writer.WriteEndObject();
        }
    }

}
