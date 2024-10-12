namespace DriveToGetDataWebsitePrototype.Services
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    public class TimeStringConverter : JsonConverter<double?>
    {
        public override double? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.String)
            {
                var timeString = reader.GetString();

                // Check if the string is numeric with a '+' sign (e.g., "+44.272")
                if (!string.IsNullOrEmpty(timeString) && (timeString.StartsWith("+") || timeString.StartsWith("-")))
                {
                    // Try parsing the string as a double, ignoring the '+' sign
                    if (double.TryParse(timeString.TrimStart('+'), out double result))
                    {
                        return result;
                    }
                }

                // Handle special cases like "DNF" or "+"
                if (timeString == "DNF" || timeString == "+")
                {
                    return null; // Treat "DNF" and "+" as null
                }
            }

            // Handle cases where the value is a number (e.g., 44.272)
            if (reader.TokenType == JsonTokenType.Number)
            {
                return reader.GetDouble(); // Parse the number as double
            }

            return null; // Return null for invalid or missing values
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
