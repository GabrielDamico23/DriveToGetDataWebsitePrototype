using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DriveToGetDataWebsitePrototype.Migrations
{
    /// <inheritdoc />
    public partial class Update3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Circuits",
                keyColumn: "CircuitId",
                keyValue: "albert_park");

            migrationBuilder.DeleteData(
                table: "Circuits",
                keyColumn: "CircuitId",
                keyValue: "americas");

            migrationBuilder.DeleteData(
                table: "Circuits",
                keyColumn: "CircuitId",
                keyValue: "bahrain");

            migrationBuilder.DeleteData(
                table: "Circuits",
                keyColumn: "CircuitId",
                keyValue: "baku");

            migrationBuilder.DeleteData(
                table: "Circuits",
                keyColumn: "CircuitId",
                keyValue: "catalunya");

            migrationBuilder.DeleteData(
                table: "Circuits",
                keyColumn: "CircuitId",
                keyValue: "hungaroring");

            migrationBuilder.DeleteData(
                table: "Circuits",
                keyColumn: "CircuitId",
                keyValue: "imola");

            migrationBuilder.DeleteData(
                table: "Circuits",
                keyColumn: "CircuitId",
                keyValue: "interlagos");

            migrationBuilder.DeleteData(
                table: "Circuits",
                keyColumn: "CircuitId",
                keyValue: "jeddah");

            migrationBuilder.DeleteData(
                table: "Circuits",
                keyColumn: "CircuitId",
                keyValue: "losail");

            migrationBuilder.DeleteData(
                table: "Circuits",
                keyColumn: "CircuitId",
                keyValue: "marina_bay");

            migrationBuilder.DeleteData(
                table: "Circuits",
                keyColumn: "CircuitId",
                keyValue: "miami");

            migrationBuilder.DeleteData(
                table: "Circuits",
                keyColumn: "CircuitId",
                keyValue: "monaco");

            migrationBuilder.DeleteData(
                table: "Circuits",
                keyColumn: "CircuitId",
                keyValue: "monza");

            migrationBuilder.DeleteData(
                table: "Circuits",
                keyColumn: "CircuitId",
                keyValue: "red_bull_ring");

            migrationBuilder.DeleteData(
                table: "Circuits",
                keyColumn: "CircuitId",
                keyValue: "ricard");

            migrationBuilder.DeleteData(
                table: "Circuits",
                keyColumn: "CircuitId",
                keyValue: "rodriguez");

            migrationBuilder.DeleteData(
                table: "Circuits",
                keyColumn: "CircuitId",
                keyValue: "shanghai");

            migrationBuilder.DeleteData(
                table: "Circuits",
                keyColumn: "CircuitId",
                keyValue: "silverstone");

            migrationBuilder.DeleteData(
                table: "Circuits",
                keyColumn: "CircuitId",
                keyValue: "spa");

            migrationBuilder.DeleteData(
                table: "Circuits",
                keyColumn: "CircuitId",
                keyValue: "suzuka");

            migrationBuilder.DeleteData(
                table: "Circuits",
                keyColumn: "CircuitId",
                keyValue: "vegas");

            migrationBuilder.DeleteData(
                table: "Circuits",
                keyColumn: "CircuitId",
                keyValue: "villeneuve");

            migrationBuilder.DeleteData(
                table: "Circuits",
                keyColumn: "CircuitId",
                keyValue: "yas_marina");

            migrationBuilder.DeleteData(
                table: "Circuits",
                keyColumn: "CircuitId",
                keyValue: "zandvoort");

            migrationBuilder.RenameColumn(
                name: "F1DriverId",
                table: "Drivers",
                newName: "DriverId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DriverId",
                table: "Drivers",
                newName: "F1DriverId");

            migrationBuilder.InsertData(
                table: "Circuits",
                columns: new[] { "CircuitId", "CircuitName", "Country", "Locality", "Url" },
                values: new object[,]
                {
                    { "albert_park", "Albert Park Grand Prix Circuit", "Australia", "Melbourne", "http://en.wikipedia.org/wiki/Melbourne_Grand_Prix_Circuit" },
                    { "americas", "Circuit of the Americas", "USA", "Austin", "http://en.wikipedia.org/wiki/Circuit_of_the_Americas" },
                    { "bahrain", "Bahrain International Circuit", "Bahrain", "Sakhir", "http://en.wikipedia.org/wiki/Bahrain_International_Circuit" },
                    { "baku", "Baku City Circuit", "Azerbaijan", "Baku", "http://en.wikipedia.org/wiki/Baku_City_Circuit" },
                    { "catalunya", "Circuit de Barcelona-Catalunya", "Spain", "Montmelo", "http://en.wikipedia.org/wiki/Circuit_de_Barcelona-Catalunya" },
                    { "hungaroring", "Hungaroring", "Hungary", "Budapest", "http://en.wikipedia.org/wiki/Hungaroring" },
                    { "imola", "Autodromo Enzo e Dino Ferrari", "Italy", "Imola", "http://en.wikipedia.org/wiki/Autodromo_Enzo_e_Dino_Ferrari" },
                    { "interlagos", "Autodromo Jose Carlos Pace", "Brazil", "Sao Paulo", "http://en.wikipedia.org/wiki/Aut%C3%B3dromo_Jos%C3%A9_Carlos_Pace" },
                    { "jeddah", "Jeddah Corniche Circuit", "Saudi Arabia", "Jeddah", "http://en.wikipedia.org/wiki/Jeddah_Street_Circuit" },
                    { "losail", "Losail International Circuit", "Qatar", "Al Daayen", "http://en.wikipedia.org/wiki/Losail_International_Circuit" },
                    { "marina_bay", "Marina Bay Street Circuit", "Singapore", "Marina Bay", "http://en.wikipedia.org/wiki/Marina_Bay_Street_Circuit" },
                    { "miami", "Miami International Autodrome", "USA", "Miami", "http://en.wikipedia.org/wiki/Miami_International_Autodrome" },
                    { "monaco", "Circuit de Monaco", "Monaco", "Monte Carlo", "http://en.wikipedia.org/wiki/Circuit_de_Monaco" },
                    { "monza", "Autodromo Nazionale di Monza", "Italy", "Monza", "http://en.wikipedia.org/wiki/Autodromo_Nazionale_Monza" },
                    { "red_bull_ring", "Red Bull Ring", "Austria", "Spielberg", "http://en.wikipedia.org/wiki/Red_Bull_Ring" },
                    { "ricard", "Circuit Paul Ricard", "France", "Le Castellet", "http://en.wikipedia.org/wiki/Paul_Ricard_Circuit" },
                    { "rodriguez", "Autodromo Hermanos Rodriguez", "Mexico", "Mexico City", "http://en.wikipedia.org/wiki/Aut%C3%B3dromo_Hermanos_Rodr%C3%ADguez" },
                    { "shanghai", "Shanghai International Circuit", "China", "Shanghai", "http://en.wikipedia.org/wiki/Shanghai_International_Circuit" },
                    { "silverstone", "Silverstone Circuit", "UK", "Silverstone", "http://en.wikipedia.org/wiki/Silverstone_Circuit" },
                    { "spa", "Circuit de Spa-Francorchamps", "Belgium", "Spa", "http://en.wikipedia.org/wiki/Circuit_de_Spa-Francorchamps" },
                    { "suzuka", "Suzuka Circuit", "Japan", "Suzuka", "http://en.wikipedia.org/wiki/Suzuka_Circuit" },
                    { "vegas", "Las Vegas Strip Street Circuit", "USA", "Las Vegas", "https://en.wikipedia.org/wiki/Las_Vegas_Grand_Prix#Circuit" },
                    { "villeneuve", "Circuit Gilles Villeneuve", "Canada", "Montreal", "http://en.wikipedia.org/wiki/Circuit_Gilles_Villeneuve" },
                    { "yas_marina", "Yas Marina Circuit", "UAE", "Abu Dhabi", "http://en.wikipedia.org/wiki/Yas_Marina_Circuit" },
                    { "zandvoort", "Circuit Zandvoort", "Netherlands", "Zandvoort", "http://en.wikipedia.org/wiki/Circuit_Zandvoort" }
                });
        }
    }
}
