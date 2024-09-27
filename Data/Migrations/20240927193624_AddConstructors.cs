using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DriveToGetDataWebsitePrototype.Migrations
{
    /// <inheritdoc />
    public partial class AddConstructors : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Driver",
                table: "Driver");

            migrationBuilder.DeleteData(
                table: "Driver",
                keyColumn: "DriverId",
                keyValue: "albon");

            migrationBuilder.DeleteData(
                table: "Driver",
                keyColumn: "DriverId",
                keyValue: "alonso");

            migrationBuilder.DeleteData(
                table: "Driver",
                keyColumn: "DriverId",
                keyValue: "bearman");

            migrationBuilder.DeleteData(
                table: "Driver",
                keyColumn: "DriverId",
                keyValue: "bottas");

            migrationBuilder.DeleteData(
                table: "Driver",
                keyColumn: "DriverId",
                keyValue: "colapinto");

            migrationBuilder.DeleteData(
                table: "Driver",
                keyColumn: "DriverId",
                keyValue: "deVries");

            migrationBuilder.DeleteData(
                table: "Driver",
                keyColumn: "DriverId",
                keyValue: "gasly");

            migrationBuilder.DeleteData(
                table: "Driver",
                keyColumn: "DriverId",
                keyValue: "Guanyu");

            migrationBuilder.DeleteData(
                table: "Driver",
                keyColumn: "DriverId",
                keyValue: "hamilton");

            migrationBuilder.DeleteData(
                table: "Driver",
                keyColumn: "DriverId",
                keyValue: "hulkenberg");

            migrationBuilder.DeleteData(
                table: "Driver",
                keyColumn: "DriverId",
                keyValue: "latifi");

            migrationBuilder.DeleteData(
                table: "Driver",
                keyColumn: "DriverId",
                keyValue: "lawson");

            migrationBuilder.DeleteData(
                table: "Driver",
                keyColumn: "DriverId",
                keyValue: "leclerc");

            migrationBuilder.DeleteData(
                table: "Driver",
                keyColumn: "DriverId",
                keyValue: "magnussen");

            migrationBuilder.DeleteData(
                table: "Driver",
                keyColumn: "DriverId",
                keyValue: "norris");

            migrationBuilder.DeleteData(
                table: "Driver",
                keyColumn: "DriverId",
                keyValue: "ocon");

            migrationBuilder.DeleteData(
                table: "Driver",
                keyColumn: "DriverId",
                keyValue: "perez");

            migrationBuilder.DeleteData(
                table: "Driver",
                keyColumn: "DriverId",
                keyValue: "piastri");

            migrationBuilder.DeleteData(
                table: "Driver",
                keyColumn: "DriverId",
                keyValue: "ricciardo");

            migrationBuilder.DeleteData(
                table: "Driver",
                keyColumn: "DriverId",
                keyValue: "russell");

            migrationBuilder.DeleteData(
                table: "Driver",
                keyColumn: "DriverId",
                keyValue: "sainz");

            migrationBuilder.DeleteData(
                table: "Driver",
                keyColumn: "DriverId",
                keyValue: "sargeant");

            migrationBuilder.DeleteData(
                table: "Driver",
                keyColumn: "DriverId",
                keyValue: "schumacher");

            migrationBuilder.DeleteData(
                table: "Driver",
                keyColumn: "DriverId",
                keyValue: "stroll");

            migrationBuilder.DeleteData(
                table: "Driver",
                keyColumn: "DriverId",
                keyValue: "tsunoda");

            migrationBuilder.DeleteData(
                table: "Driver",
                keyColumn: "DriverId",
                keyValue: "verstappen");

            migrationBuilder.DeleteData(
                table: "Driver",
                keyColumn: "DriverId",
                keyValue: "vettel");

            migrationBuilder.RenameTable(
                name: "Driver",
                newName: "Drivers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Drivers",
                table: "Drivers",
                column: "DriverId");

            migrationBuilder.CreateTable(
                name: "Constructor",
                columns: table => new
                {
                    ConstructorId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ConstructorName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nationality = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Constructor", x => x.ConstructorId);
                });

            migrationBuilder.InsertData(
                table: "Constructor",
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
                name: "Constructor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Drivers",
                table: "Drivers");

            migrationBuilder.RenameTable(
                name: "Drivers",
                newName: "Driver");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Driver",
                table: "Driver",
                column: "DriverId");

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
    }
}
