namespace DriveToGetDataWebsitePrototype.Services
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    public class TimeConverter : JsonConverter<double?>
    {
        public override double? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            // Handle numeric values (e.g., 44.272 or +44.272)
            if (reader.TokenType == JsonTokenType.Number)
            {
                return reader.GetDouble();
            }

            // Handle string values (e.g., "DNF", "N/A")
            if (reader.TokenType == JsonTokenType.String)
            {
                var stringValue = reader.GetString();
                if (stringValue == "DNF" || stringValue == "+")
                {
                    return null; // Interpret "DNF" and "+" as null
                }
            }

            // If the value is not recognized or valid, return null
            return null;
        }

        public override void Write(Utf8JsonWriter writer, double? value, JsonSerializerOptions options)
        {
            if (value.HasValue)
            {
                writer.WriteNumberValue(value.Value); // Write the numeric value
            }
            else
            {
                writer.WriteNullValue(); // Write null if no time
            }
        }
    }

}
