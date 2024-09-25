using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DriveToGetDataWebsitePrototype.Migrations
{
    /// <inheritdoc />
    public partial class AddDrivers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Driver",
                columns: table => new
                {
                    DriverId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    GivenName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FamilyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PermanentNumber = table.Column<int>(type: "int", nullable: false),
                    Nationality = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Driver", x => x.DriverId);
                });

            migrationBuilder.InsertData(
                table: "Driver",
                columns: new[] { "DriverId", "FamilyName", "GivenName", "Nationality", "PermanentNumber" },
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Driver");
        }
    }
}
