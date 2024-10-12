namespace DriveToGetDataWebsitePrototype.Services
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    public class TimeSpanConverter : JsonConverter<TimeSpan?>
    {
        public override TimeSpan? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.String)
            {
                var timeString = reader.GetString();

                // Try to parse valid time strings (e.g., "1:34:50.610")
                if (TimeSpan.TryParse(timeString, out TimeSpan parsedTime))
                {
                    return parsedTime;
                }

                // Handle special cases like "DNF" or "+" by returning null
                if (timeString == "DNF" || timeString == "+")
                {
                    return null;
                }
            }

            return null; // Return null if the value is invalid or missing
        }

        public override void Write(Utf8JsonWriter writer, TimeSpan? value, JsonSerializerOptions options)
        {
            if (value.HasValue)
            {
                writer.WriteStringValue(value.Value.ToString(@"hh\:mm\:ss\.fff"));
            }
            else
            {
                writer.WriteNullValue(); // Write null if no time
            }
        }
    }
}

