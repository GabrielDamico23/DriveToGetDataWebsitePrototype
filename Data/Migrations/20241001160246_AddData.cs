using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DriveToGetDataWebsitePrototype.Migrations
{
    /// <inheritdoc />
    public partial class AddData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Drivers",
                columns: table => new
                {
                    F1DriverId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    GivenName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FamilyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PermanentNumber = table.Column<int>(type: "int", nullable: false),
                    Nationality = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Driver", x => x.F1DriverId);
                });

            migrationBuilder.InsertData(
                table: "Drivers",
                columns: new[] { "F1DriverId", "FamilyName", "GivenName", "Nationality", "PermanentNumber" },
                values: new object[,]
                {
                    { "albon", "Albon", "Alexander", "Thai", 23 },
                    { "alonso", "Alonso", "Fernando", "Spanish", 14 },
                    { "bearman", "Bearman", "Oliver", "British", 50 },
                    { "bottas", "Bottas", "Valtteri", "Finnish", 77 },
                    { "colapinto", "Colapinto", "Franco", "Argentinian", 43 },
                    { "deVries", "de Vries", "Nyck", "Dutch", 7 },
                    { "gasly", "Gasly", "Pierre", "French", 10 },
                    { "Guanyu", "Zhou", "Zhou", "Chinese", 24 },
                    { "hamilton", "Hamilton", "Lewis", "British", 44 },
                    { "hulkenberg", "Hulkenberg", "Nico", "German", 27 },
                    { "latifi", "Latifi", "Nicholas", "Canadian", 6 },
                    { "lawson", "Lawson", "Liam", "New Zealander", 36 },
                    { "leclerc", "Leclerc", "Charles", "Monegasque", 16 },
                    { "magnussen", "Magnussen", "Kevin", "Danish", 20 },
                    { "norris", "Norris", "Lando", "British", 4 },
                    { "ocon", "Ocon", "Esteban", "French", 31 },
                    { "perez", "Perez", "Sergio", "Mexican", 11 },
                    { "piastri", "Piastri", "Oscar", "Australian", 81 },
                    { "ricciardo", "Ricciardo", "Daniel", "Australian", 3 },
                    { "russell", "Russell", "George", "British", 63 },
                    { "sainz", "Sainz", "Carlos", "Spanish", 55 },
                    { "sargeant", "Sargeant", "Logan", "American", 2 },
                    { "schumacher", "Schumacher", "Mick", "German", 47 },
                    { "stroll", "Stroll", "Lance", "Canadian", 18 },
                    { "tsunoda", "Tsunoda", "Yuki", "Japanese", 22 },
                    { "verstappen", "Verstappen", "Max", "Dutch", 1 },
                    { "vettel", "Vettel", "Sebastian", "German", 5 }
                });

            migrationBuilder.CreateTable(
                name: "Circuits",
                columns: table => new
                {
                    CircuitId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CircuitName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Locality = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Circuits", x => x.CircuitId);
                });

            migrationBuilder.CreateTable(
                name: "Constructors",
                columns: table => new
                {
                    ConstructorId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ConstructorName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nationality = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Constructors", x => x.ConstructorId);
                });

            migrationBuilder.InsertData(
                table: "Circuits",
                columns: new[] { "CircuitId", "CircuitName", "Country", "Locality" },
                values: new object[,]
                {
                    { "albert_park", "Albert Park Grand Prix Circuit", "Australia", "Melbourne" },
                    { "americas", "Circuit of the Americas", "USA", "Austin" },
                    { "bahrain", "Bahrain International Circuit", "Bahrain", "Sakhir" },
                    { "baku", "Baku City Circuit", "Azerbaijan", "Baku" },
                    { "catalunya", "Circuit de Barcelona-Catalunya", "Spain", "Montmelo" },
                    { "hungaroring", "Hungaroring", "Hungary", "Budapest" },
                    { "imola", "Autodromo Enzo e Dino Ferrari", "Italy", "Imola" },
                    { "interlagos", "Autodromo Jose Carlos Pace", "Brazil", "Sao Paulo" },
                    { "jeddah", "Jeddah Corniche Circuit", "Saudi Arabia", "Jeddah" },
                    { "losail", "Losail International Circuit", "Qatar", "Al Daayen" },
                    { "marina_bay", "Marina Bay Street Circuit", "Singapore", "Marina Bay" },
                    { "miami", "Miami International Autodrome", "USA", "Miami" },
                    { "monaco", "Circuit de Monaco", "Monaco", "Monte Carlo" },
                    { "monza", "Autodromo Nazionale di Monza", "Italy", "Monza" },
                    { "red_bull_ring", "Red Bull Ring", "Austria", "Spielberg" },
                    { "ricard", "Circuit Paul Ricard", "France", "Le Castellet" },
                    { "rodriguez", "Autodromo Hermanos Rodriguez", "Mexico", "Mexico City" },
                    { "shanghai", "Shanghai International Circuit", "China", "Shanghai" },
                    { "silverstone", "Silverstone Circuit", "UK", "Silverstone" },
                    { "spa", "Circuit de Spa-Francorchamps", "Belgium", "Spa" },
                    { "suzuka", "Suzuka Circuit", "Japan", "Suzuka" },
                    { "vegas", "Las Vegas Strip Street Circuit", "USA", "Las Vegas" },
                    { "villeneuve", "Circuit Gilles Villeneuve", "Canada", "Montreal" },
                    { "yas_marina", "Yas Marina Circuit", "UAE", "Abu Dhabi" },
                    { "zandvoort", "Circuit Zandvoort", "Netherlands", "Zandvoort" }
                });

            migrationBuilder.InsertData(
                table: "Constructors",
                columns: new[] { "ConstructorId", "ConstructorName", "Nationality" },
                values: new object[,]
                {
                    { "alpine", "Alpine F1 Team", "French" },
                    { "astone_martin", "Aston Martin", "British" },
                    { "ferrari", "Ferrari", "Italian" },
                    { "haas", "Haas F1 Team", "American" },
                    { "mclaren", "McLaren", "British" },
                    { "mercedes", "Mercedes", "German" },
                    { "rb", "RB F1 Team", "Italian" },
                    { "red_bull", "Red Bull", "Austrian" },
                    { "sauber", "Sauber", "Swiss" },
                    { "williams", "Williams", "British" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Drivers");

            migrationBuilder.DropTable(
                name: "Circuits");

            migrationBuilder.DropTable(
                name: "Constructors");
        }
    }
}
