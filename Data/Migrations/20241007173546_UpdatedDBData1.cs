using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DriveToGetDataWebsitePrototype.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedDBData1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Constructors",
                keyColumn: "ConstructorId",
                keyValue: "astone_martin");

            migrationBuilder.AddColumn<string>(
                name: "Driver1",
                table: "Constructors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Driver2",
                table: "Constructors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Constructors",
                keyColumn: "ConstructorId",
                keyValue: "alpine",
                columns: new[] { "Driver1", "Driver2" },
                values: new object[] { "Pierre Gasly", "Esteban Ocon" });

            migrationBuilder.UpdateData(
                table: "Constructors",
                keyColumn: "ConstructorId",
                keyValue: "ferrari",
                columns: new[] { "Driver1", "Driver2" },
                values: new object[] { "Charles Leclerc", "Carlos Sainz" });

            migrationBuilder.UpdateData(
                table: "Constructors",
                keyColumn: "ConstructorId",
                keyValue: "haas",
                columns: new[] { "Driver1", "Driver2" },
                values: new object[] { "Nico Hülkenberg", "Kevin Magnussen" });

            migrationBuilder.UpdateData(
                table: "Constructors",
                keyColumn: "ConstructorId",
                keyValue: "mclaren",
                columns: new[] { "Driver1", "Driver2" },
                values: new object[] { "Lando Norris", "Oscar Piastri" });

            migrationBuilder.UpdateData(
                table: "Constructors",
                keyColumn: "ConstructorId",
                keyValue: "mercedes",
                columns: new[] { "Driver1", "Driver2" },
                values: new object[] { "Lewis Hamilton", "George Russell" });

            migrationBuilder.UpdateData(
                table: "Constructors",
                keyColumn: "ConstructorId",
                keyValue: "rb",
                columns: new[] { "Driver1", "Driver2" },
                values: new object[] { "Yuki Tsunoda", "Liam Lawson" });

            migrationBuilder.UpdateData(
                table: "Constructors",
                keyColumn: "ConstructorId",
                keyValue: "red_bull",
                columns: new[] { "Driver1", "Driver2" },
                values: new object[] { "Max Verstappen", "Sergio Pérez" });

            migrationBuilder.UpdateData(
                table: "Constructors",
                keyColumn: "ConstructorId",
                keyValue: "sauber",
                columns: new[] { "Driver1", "Driver2" },
                values: new object[] { "Valtteri Bottas", "Guanyu Zhou" });

            migrationBuilder.UpdateData(
                table: "Constructors",
                keyColumn: "ConstructorId",
                keyValue: "williams",
                columns: new[] { "Driver1", "Driver2" },
                values: new object[] { "Alexander Albon", "Franco Colapinto" });

            migrationBuilder.InsertData(
                table: "Constructors",
                columns: new[] { "ConstructorId", "ConstructorName", "Driver1", "Driver2", "Nationality", "Url" },
                values: new object[] { "aston_martin", "Aston Martin", "Fernando Alonso", "Lance Stoll", "British", "http://en.wikipedia.org/wiki/Aston_Martin_in_Formula_One" });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "F1DriverId",
                keyValue: "zhou",
                columns: new[] { "FamilyName", "GivenName" },
                values: new object[] { "Zhou", "Guanyu" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Constructors",
                keyColumn: "ConstructorId",
                keyValue: "aston_martin");

            migrationBuilder.DropColumn(
                name: "Driver1",
                table: "Constructors");

            migrationBuilder.DropColumn(
                name: "Driver2",
                table: "Constructors");

            migrationBuilder.InsertData(
                table: "Constructors",
                columns: new[] { "ConstructorId", "ConstructorName", "Nationality", "Url" },
                values: new object[] { "astone_martin", "Aston Martin", "British", "http://en.wikipedia.org/wiki/Aston_Martin_in_Formula_One" });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "F1DriverId",
                keyValue: "zhou",
                columns: new[] { "FamilyName", "GivenName" },
                values: new object[] { "Guanyu", "Zhou" });
        }
    }
}
