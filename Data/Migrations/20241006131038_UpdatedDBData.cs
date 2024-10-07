using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DriveToGetDataWebsitePrototype.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedDBData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "F1DriverId",
                keyValue: "deVries");

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "F1DriverId",
                keyValue: "Guanyu");

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "F1DriverId",
                keyValue: "magnussen");

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "F1DriverId",
                keyValue: "schumacher");

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "F1DriverId",
                keyValue: "verstappen");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Drivers");

            migrationBuilder.AddColumn<string>(
                name: "DateOfBirth",
                table: "Drivers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Url",
                table: "Drivers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Url",
                table: "Constructors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Url",
                table: "Circuits",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Circuits",
                keyColumn: "CircuitId",
                keyValue: "albert_park",
                column: "Url",
                value: "http://en.wikipedia.org/wiki/Melbourne_Grand_Prix_Circuit");

            migrationBuilder.UpdateData(
                table: "Circuits",
                keyColumn: "CircuitId",
                keyValue: "americas",
                column: "Url",
                value: "http://en.wikipedia.org/wiki/Circuit_of_the_Americas");

            migrationBuilder.UpdateData(
                table: "Circuits",
                keyColumn: "CircuitId",
                keyValue: "bahrain",
                column: "Url",
                value: "http://en.wikipedia.org/wiki/Bahrain_International_Circuit");

            migrationBuilder.UpdateData(
                table: "Circuits",
                keyColumn: "CircuitId",
                keyValue: "baku",
                column: "Url",
                value: "http://en.wikipedia.org/wiki/Baku_City_Circuit");

            migrationBuilder.UpdateData(
                table: "Circuits",
                keyColumn: "CircuitId",
                keyValue: "catalunya",
                column: "Url",
                value: "http://en.wikipedia.org/wiki/Circuit_de_Barcelona-Catalunya");

            migrationBuilder.UpdateData(
                table: "Circuits",
                keyColumn: "CircuitId",
                keyValue: "hungaroring",
                column: "Url",
                value: "http://en.wikipedia.org/wiki/Hungaroring");

            migrationBuilder.UpdateData(
                table: "Circuits",
                keyColumn: "CircuitId",
                keyValue: "imola",
                column: "Url",
                value: "http://en.wikipedia.org/wiki/Autodromo_Enzo_e_Dino_Ferrari");

            migrationBuilder.UpdateData(
                table: "Circuits",
                keyColumn: "CircuitId",
                keyValue: "interlagos",
                column: "Url",
                value: "http://en.wikipedia.org/wiki/Aut%C3%B3dromo_Jos%C3%A9_Carlos_Pace");

            migrationBuilder.UpdateData(
                table: "Circuits",
                keyColumn: "CircuitId",
                keyValue: "jeddah",
                column: "Url",
                value: "http://en.wikipedia.org/wiki/Jeddah_Street_Circuit");

            migrationBuilder.UpdateData(
                table: "Circuits",
                keyColumn: "CircuitId",
                keyValue: "losail",
                column: "Url",
                value: "http://en.wikipedia.org/wiki/Losail_International_Circuit");

            migrationBuilder.UpdateData(
                table: "Circuits",
                keyColumn: "CircuitId",
                keyValue: "marina_bay",
                column: "Url",
                value: "http://en.wikipedia.org/wiki/Marina_Bay_Street_Circuit");

            migrationBuilder.UpdateData(
                table: "Circuits",
                keyColumn: "CircuitId",
                keyValue: "miami",
                column: "Url",
                value: "http://en.wikipedia.org/wiki/Miami_International_Autodrome");

            migrationBuilder.UpdateData(
                table: "Circuits",
                keyColumn: "CircuitId",
                keyValue: "monaco",
                column: "Url",
                value: "http://en.wikipedia.org/wiki/Circuit_de_Monaco");

            migrationBuilder.UpdateData(
                table: "Circuits",
                keyColumn: "CircuitId",
                keyValue: "monza",
                column: "Url",
                value: "http://en.wikipedia.org/wiki/Autodromo_Nazionale_Monza");

            migrationBuilder.UpdateData(
                table: "Circuits",
                keyColumn: "CircuitId",
                keyValue: "red_bull_ring",
                column: "Url",
                value: "http://en.wikipedia.org/wiki/Red_Bull_Ring");

            migrationBuilder.UpdateData(
                table: "Circuits",
                keyColumn: "CircuitId",
                keyValue: "ricard",
                column: "Url",
                value: "http://en.wikipedia.org/wiki/Paul_Ricard_Circuit");

            migrationBuilder.UpdateData(
                table: "Circuits",
                keyColumn: "CircuitId",
                keyValue: "rodriguez",
                column: "Url",
                value: "http://en.wikipedia.org/wiki/Aut%C3%B3dromo_Hermanos_Rodr%C3%ADguez");

            migrationBuilder.UpdateData(
                table: "Circuits",
                keyColumn: "CircuitId",
                keyValue: "shanghai",
                column: "Url",
                value: "http://en.wikipedia.org/wiki/Shanghai_International_Circuit");

            migrationBuilder.UpdateData(
                table: "Circuits",
                keyColumn: "CircuitId",
                keyValue: "silverstone",
                column: "Url",
                value: "http://en.wikipedia.org/wiki/Silverstone_Circuit");

            migrationBuilder.UpdateData(
                table: "Circuits",
                keyColumn: "CircuitId",
                keyValue: "spa",
                column: "Url",
                value: "http://en.wikipedia.org/wiki/Circuit_de_Spa-Francorchamps");

            migrationBuilder.UpdateData(
                table: "Circuits",
                keyColumn: "CircuitId",
                keyValue: "suzuka",
                column: "Url",
                value: "http://en.wikipedia.org/wiki/Suzuka_Circuit");

            migrationBuilder.UpdateData(
                table: "Circuits",
                keyColumn: "CircuitId",
                keyValue: "vegas",
                column: "Url",
                value: "https://en.wikipedia.org/wiki/Las_Vegas_Grand_Prix#Circuit");

            migrationBuilder.UpdateData(
                table: "Circuits",
                keyColumn: "CircuitId",
                keyValue: "villeneuve",
                column: "Url",
                value: "http://en.wikipedia.org/wiki/Circuit_Gilles_Villeneuve");

            migrationBuilder.UpdateData(
                table: "Circuits",
                keyColumn: "CircuitId",
                keyValue: "yas_marina",
                column: "Url",
                value: "http://en.wikipedia.org/wiki/Yas_Marina_Circuit");

            migrationBuilder.UpdateData(
                table: "Circuits",
                keyColumn: "CircuitId",
                keyValue: "zandvoort",
                column: "Url",
                value: "http://en.wikipedia.org/wiki/Circuit_Zandvoort");

            migrationBuilder.UpdateData(
                table: "Constructors",
                keyColumn: "ConstructorId",
                keyValue: "alpine",
                column: "Url",
                value: "http://en.wikipedia.org/wiki/Alpine_F1_Team");

            migrationBuilder.UpdateData(
                table: "Constructors",
                keyColumn: "ConstructorId",
                keyValue: "astone_martin",
                column: "Url",
                value: "http://en.wikipedia.org/wiki/Aston_Martin_in_Formula_One");

            migrationBuilder.UpdateData(
                table: "Constructors",
                keyColumn: "ConstructorId",
                keyValue: "ferrari",
                column: "Url",
                value: "http://en.wikipedia.org/wiki/Scuderia_Ferrari");

            migrationBuilder.UpdateData(
                table: "Constructors",
                keyColumn: "ConstructorId",
                keyValue: "haas",
                column: "Url",
                value: "http://en.wikipedia.org/wiki/Haas_F1_Team");

            migrationBuilder.UpdateData(
                table: "Constructors",
                keyColumn: "ConstructorId",
                keyValue: "mclaren",
                column: "Url",
                value: "http://en.wikipedia.org/wiki/McLaren");

            migrationBuilder.UpdateData(
                table: "Constructors",
                keyColumn: "ConstructorId",
                keyValue: "mercedes",
                column: "Url",
                value: "http://en.wikipedia.org/wiki/Mercedes-Benz_in_Formula_One");

            migrationBuilder.UpdateData(
                table: "Constructors",
                keyColumn: "ConstructorId",
                keyValue: "rb",
                column: "Url",
                value: "http://en.wikipedia.org/wiki/RB_Formula_One_Team");

            migrationBuilder.UpdateData(
                table: "Constructors",
                keyColumn: "ConstructorId",
                keyValue: "red_bull",
                column: "Url",
                value: "http://en.wikipedia.org/wiki/Red_Bull_Racing");

            migrationBuilder.UpdateData(
                table: "Constructors",
                keyColumn: "ConstructorId",
                keyValue: "sauber",
                column: "Url",
                value: "http://en.wikipedia.org/wiki/Sauber_Motorsport");

            migrationBuilder.UpdateData(
                table: "Constructors",
                keyColumn: "ConstructorId",
                keyValue: "williams",
                column: "Url",
                value: "http://en.wikipedia.org/wiki/Williams_Grand_Prix_Engineering");

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "F1DriverId",
                keyValue: "albon",
                columns: new[] { "DateOfBirth", "Url" },
                values: new object[] { "1996-03-23", "http://en.wikipedia.org/wiki/Alexander_Albon" });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "F1DriverId",
                keyValue: "alonso",
                columns: new[] { "DateOfBirth", "Url" },
                values: new object[] { "1981-07-29", "http://en.wikipedia.org/wiki/Fernando_Alonso" });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "F1DriverId",
                keyValue: "bearman",
                columns: new[] { "DateOfBirth", "Url" },
                values: new object[] { "2005-05-08", "http://en.wikipedia.org/wiki/Oliver_Bearman" });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "F1DriverId",
                keyValue: "bottas",
                columns: new[] { "DateOfBirth", "Url" },
                values: new object[] { "1989-08-28", "http://en.wikipedia.org/wiki/Valtteri_Bottas" });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "F1DriverId",
                keyValue: "colapinto",
                columns: new[] { "DateOfBirth", "Url" },
                values: new object[] { "2003-05-27", "http://en.wikipedia.org/wiki/Franco_Colapinto" });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "F1DriverId",
                keyValue: "gasly",
                columns: new[] { "DateOfBirth", "Url" },
                values: new object[] { "1996-02-07", "http://en.wikipedia.org/wiki/Pierre_Gasly" });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "F1DriverId",
                keyValue: "hamilton",
                columns: new[] { "DateOfBirth", "Url" },
                values: new object[] { "1985-01-07", "http://en.wikipedia.org/wiki/Lewis_Hamilton" });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "F1DriverId",
                keyValue: "hulkenberg",
                columns: new[] { "DateOfBirth", "Url" },
                values: new object[] { "1987-08-19", "http://en.wikipedia.org/wiki/Nico_H%C3%BClkenberg" });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "F1DriverId",
                keyValue: "latifi",
                columns: new[] { "DateOfBirth", "Url" },
                values: new object[] { "1995-06-29", "http://en.wikipedia.org/wiki/Nicholas_Latifi" });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "F1DriverId",
                keyValue: "lawson",
                columns: new[] { "DateOfBirth", "Url" },
                values: new object[] { "2002-02-11", "http://en.wikipedia.org/wiki/Liam_Lawson" });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "F1DriverId",
                keyValue: "leclerc",
                columns: new[] { "DateOfBirth", "Url" },
                values: new object[] { "1997-10-16", "http://en.wikipedia.org/wiki/Charles_Leclerc" });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "F1DriverId",
                keyValue: "norris",
                columns: new[] { "DateOfBirth", "Url" },
                values: new object[] { "1999-11-13", "http://en.wikipedia.org/wiki/Lando_Norris" });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "F1DriverId",
                keyValue: "ocon",
                columns: new[] { "DateOfBirth", "Url" },
                values: new object[] { "1996-09-17", "http://en.wikipedia.org/wiki/Esteban_Ocon" });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "F1DriverId",
                keyValue: "perez",
                columns: new[] { "DateOfBirth", "Url" },
                values: new object[] { "1990-01-26", "http://en.wikipedia.org/wiki/Sergio_P%C3%A9rez" });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "F1DriverId",
                keyValue: "piastri",
                columns: new[] { "DateOfBirth", "Url" },
                values: new object[] { "2001-04-06", "http://en.wikipedia.org/wiki/Oscar_Piastri" });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "F1DriverId",
                keyValue: "ricciardo",
                columns: new[] { "DateOfBirth", "Url" },
                values: new object[] { "1989-07-01", "http://en.wikipedia.org/wiki/Daniel_Ricciardo" });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "F1DriverId",
                keyValue: "russell",
                columns: new[] { "DateOfBirth", "Url" },
                values: new object[] { "1998-02-15", "http://en.wikipedia.org/wiki/George_Russell_(racing_driver)" });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "F1DriverId",
                keyValue: "sainz",
                columns: new[] { "DateOfBirth", "Url" },
                values: new object[] { "1994-09-01", "http://en.wikipedia.org/wiki/Carlos_Sainz_Jr." });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "F1DriverId",
                keyValue: "sargeant",
                columns: new[] { "DateOfBirth", "Url" },
                values: new object[] { "2000-12-31", "http://en.wikipedia.org/wiki/Logan_Sargeant" });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "F1DriverId",
                keyValue: "stroll",
                columns: new[] { "DateOfBirth", "Url" },
                values: new object[] { "1998-10-29", "http://en.wikipedia.org/wiki/Lance_Stroll" });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "F1DriverId",
                keyValue: "tsunoda",
                columns: new[] { "DateOfBirth", "Url" },
                values: new object[] { "2000-05-11", "http://en.wikipedia.org/wiki/Yuki_Tsunoda" });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "F1DriverId",
                keyValue: "vettel",
                columns: new[] { "DateOfBirth", "Url" },
                values: new object[] { "1987-07-03", "http://en.wikipedia.org/wiki/Sebastian_Vettel" });

            migrationBuilder.InsertData(
                table: "Drivers",
                columns: new[] { "F1DriverId", "DateOfBirth", "FamilyName", "GivenName", "Nationality", "PermanentNumber", "Url" },
                values: new object[,]
                {
                    { "de_vries", "1995-02-06", "de Vries", "Nyck", "Dutch", 7, "http://en.wikipedia.org/wiki/Nyck_de_Vries" },
                    { "kevin_magnussen", "1992-10-05", "Magnussen", "Kevin", "Danish", 20, "http://en.wikipedia.org/wiki/Kevin_Magnussen" },
                    { "max_verstappen", "1997-09-30", "Verstappen", "Max", "Dutch", 1, "http://en.wikipedia.org/wiki/Max_Verstappen" },
                    { "mick_schumacher", "1999-03-22", "Schumacher", "Mick", "German", 47, "http://en.wikipedia.org/wiki/Mick_Schumacher" },
                    { "zhou", "1999-05-30", "Guanyu", "Zhou", "Chinese", 24, "http://en.wikipedia.org/wiki/Zhou_Guanyu" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "F1DriverId",
                keyValue: "de_vries");

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "F1DriverId",
                keyValue: "kevin_magnussen");

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "F1DriverId",
                keyValue: "max_verstappen");

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "F1DriverId",
                keyValue: "mick_schumacher");

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "F1DriverId",
                keyValue: "zhou");

            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "Url",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "Url",
                table: "Constructors");

            migrationBuilder.DropColumn(
                name: "Url",
                table: "Circuits");

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Drivers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "F1DriverId",
                keyValue: "albon",
                column: "Image",
                value: "");

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "F1DriverId",
                keyValue: "alonso",
                column: "Image",
                value: "");

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "F1DriverId",
                keyValue: "bearman",
                column: "Image",
                value: "");

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "F1DriverId",
                keyValue: "bottas",
                column: "Image",
                value: "");

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "F1DriverId",
                keyValue: "colapinto",
                column: "Image",
                value: "");

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "F1DriverId",
                keyValue: "gasly",
                column: "Image",
                value: "");

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "F1DriverId",
                keyValue: "hamilton",
                column: "Image",
                value: "");

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "F1DriverId",
                keyValue: "hulkenberg",
                column: "Image",
                value: "");

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "F1DriverId",
                keyValue: "latifi",
                column: "Image",
                value: "");

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "F1DriverId",
                keyValue: "lawson",
                column: "Image",
                value: "");

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "F1DriverId",
                keyValue: "leclerc",
                column: "Image",
                value: "");

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "F1DriverId",
                keyValue: "norris",
                column: "Image",
                value: "");

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "F1DriverId",
                keyValue: "ocon",
                column: "Image",
                value: "");

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "F1DriverId",
                keyValue: "perez",
                column: "Image",
                value: "");

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "F1DriverId",
                keyValue: "piastri",
                column: "Image",
                value: "");

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "F1DriverId",
                keyValue: "ricciardo",
                column: "Image",
                value: "");

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "F1DriverId",
                keyValue: "russell",
                column: "Image",
                value: "");

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "F1DriverId",
                keyValue: "sainz",
                column: "Image",
                value: "");

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "F1DriverId",
                keyValue: "sargeant",
                column: "Image",
                value: "");

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "F1DriverId",
                keyValue: "stroll",
                column: "Image",
                value: "");

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "F1DriverId",
                keyValue: "tsunoda",
                column: "Image",
                value: "");

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "F1DriverId",
                keyValue: "vettel",
                column: "Image",
                value: "");

            migrationBuilder.InsertData(
                table: "Drivers",
                columns: new[] { "F1DriverId", "FamilyName", "GivenName", "Image", "Nationality", "PermanentNumber" },
                values: new object[,]
                {
                    { "deVries", "de Vries", "Nyck", "", "Dutch", 7 },
                    { "Guanyu", "Zhou", "Zhou", "", "Chinese", 24 },
                    { "magnussen", "Magnussen", "Kevin", "", "Danish", 20 },
                    { "schumacher", "Schumacher", "Mick", "", "German", 47 },
                    { "verstappen", "Verstappen", "Max", "", "Dutch", 1 }
                });
        }
    }
}
