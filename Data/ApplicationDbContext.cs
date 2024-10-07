using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using DriveToGetDataWebsitePrototype.Models;

namespace DriveToGetDataWebsitePrototype.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<F1Driver> Drivers { get; set; }
        public DbSet<Constructor> Constructors { get; set; }
        public DbSet<Circuit> Circuits { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<F1Driver>().ToTable("Drivers");
            modelBuilder.Entity<Constructor>().ToTable("Constructors");
            modelBuilder.Entity<Circuit>().ToTable("Circuits");

            modelBuilder.Entity<F1Driver>().HasData(
                new F1Driver { F1DriverId = "hamilton", GivenName = "Lewis", FamilyName = "Hamilton", PermanentNumber = 44, Nationality = "British", DateOfBirth = "1985-01-07", Url = "http://en.wikipedia.org/wiki/Lewis_Hamilton" },
                new F1Driver { F1DriverId = "bottas", GivenName = "Valtteri", FamilyName = "Bottas", PermanentNumber = 77, Nationality = "Finnish", DateOfBirth = "1989-08-28", Url = "http://en.wikipedia.org/wiki/Valtteri_Bottas" },
                new F1Driver { F1DriverId = "max_verstappen", GivenName = "Max", FamilyName = "Verstappen", PermanentNumber = 1, Nationality = "Dutch", DateOfBirth = "1997-09-30", Url = "http://en.wikipedia.org/wiki/Max_Verstappen" },
                new F1Driver { F1DriverId = "perez", GivenName = "Sergio", FamilyName = "Perez", PermanentNumber = 11, Nationality = "Mexican", DateOfBirth = "1990-01-26", Url = "http://en.wikipedia.org/wiki/Sergio_P%C3%A9rez" },
                new F1Driver { F1DriverId = "norris", GivenName = "Lando", FamilyName = "Norris", PermanentNumber = 4, Nationality = "British", DateOfBirth = "1999-11-13", Url = "http://en.wikipedia.org/wiki/Lando_Norris" },
                new F1Driver { F1DriverId = "ricciardo", GivenName = "Daniel", FamilyName = "Ricciardo", PermanentNumber = 3, Nationality = "Australian", DateOfBirth = "1989-07-01", Url = "http://en.wikipedia.org/wiki/Daniel_Ricciardo" },
                new F1Driver { F1DriverId = "sainz", GivenName = "Carlos", FamilyName = "Sainz", PermanentNumber = 55, Nationality = "Spanish", DateOfBirth = "1994-09-01", Url = "http://en.wikipedia.org/wiki/Carlos_Sainz_Jr." },
                new F1Driver { F1DriverId = "leclerc", GivenName = "Charles", FamilyName = "Leclerc", PermanentNumber = 16, Nationality = "Monegasque", DateOfBirth = "1997-10-16", Url = "http://en.wikipedia.org/wiki/Charles_Leclerc" },
                new F1Driver { F1DriverId = "piastri", GivenName = "Oscar", FamilyName = "Piastri", PermanentNumber = 81, Nationality = "Australian", DateOfBirth = "2001-04-06", Url = "http://en.wikipedia.org/wiki/Oscar_Piastri" },
                new F1Driver { F1DriverId = "russell", GivenName = "George", FamilyName = "Russell", PermanentNumber = 63, Nationality = "British", DateOfBirth = "1998-02-15", Url = "http://en.wikipedia.org/wiki/George_Russell_(racing_driver)" },
                new F1Driver { F1DriverId = "alonso", GivenName = "Fernando", FamilyName = "Alonso", PermanentNumber = 14, Nationality = "Spanish", DateOfBirth = "1981-07-29", Url = "http://en.wikipedia.org/wiki/Fernando_Alonso" },
                new F1Driver { F1DriverId = "ocon", GivenName = "Esteban", FamilyName = "Ocon", PermanentNumber = 31, Nationality = "French", DateOfBirth = "1996-09-17", Url = "http://en.wikipedia.org/wiki/Esteban_Ocon" },
                new F1Driver { F1DriverId = "hulkenberg", GivenName = "Nico", FamilyName = "Hulkenberg", PermanentNumber = 27, Nationality = "German", DateOfBirth = "1987-08-19", Url = "http://en.wikipedia.org/wiki/Nico_H%C3%BClkenberg" },
                new F1Driver { F1DriverId = "stroll", GivenName = "Lance", FamilyName = "Stroll", PermanentNumber = 18, Nationality = "Canadian", DateOfBirth = "1998-10-29", Url = "http://en.wikipedia.org/wiki/Lance_Stroll" },
                new F1Driver { F1DriverId = "tsunoda", GivenName = "Yuki", FamilyName = "Tsunoda", PermanentNumber = 22, Nationality = "Japanese", DateOfBirth = "2000-05-11", Url = "http://en.wikipedia.org/wiki/Yuki_Tsunoda" },
                new F1Driver { F1DriverId = "gasly", GivenName = "Pierre", FamilyName = "Gasly", PermanentNumber = 10, Nationality = "French", DateOfBirth = "1996-02-07", Url = "http://en.wikipedia.org/wiki/Pierre_Gasly" },
                new F1Driver { F1DriverId = "bearman", GivenName = "Oliver", FamilyName = "Bearman", PermanentNumber = 50, Nationality = "British", DateOfBirth = "2005-05-08", Url = "http://en.wikipedia.org/wiki/Oliver_Bearman" },
                new F1Driver { F1DriverId = "kevin_magnussen", GivenName = "Kevin", FamilyName = "Magnussen", PermanentNumber = 20, Nationality = "Danish", DateOfBirth = "1992-10-05", Url = "http://en.wikipedia.org/wiki/Kevin_Magnussen" },
                new F1Driver { F1DriverId = "colapinto", GivenName = "Franco", FamilyName = "Colapinto", PermanentNumber = 43, Nationality = "Argentinian", DateOfBirth = "2003-05-27", Url = "http://en.wikipedia.org/wiki/Franco_Colapinto" },
                new F1Driver { F1DriverId = "mick_schumacher", GivenName = "Mick", FamilyName = "Schumacher", PermanentNumber = 47, Nationality = "German", DateOfBirth = "1999-03-22", Url = "http://en.wikipedia.org/wiki/Mick_Schumacher" },
                new F1Driver { F1DriverId = "vettel", GivenName = "Sebastian", FamilyName = "Vettel", PermanentNumber = 5, Nationality = "German", DateOfBirth = "1987-07-03", Url = "http://en.wikipedia.org/wiki/Sebastian_Vettel" },
                new F1Driver { F1DriverId = "latifi", GivenName = "Nicholas", FamilyName = "Latifi", PermanentNumber = 6, Nationality = "Canadian", DateOfBirth = "1995-06-29", Url = "http://en.wikipedia.org/wiki/Nicholas_Latifi" },
                new F1Driver { F1DriverId = "zhou", GivenName = "Guanyu", FamilyName = "Zhou", PermanentNumber = 24, Nationality = "Chinese", DateOfBirth = "1999-05-30", Url = "http://en.wikipedia.org/wiki/Zhou_Guanyu" },
                new F1Driver { F1DriverId = "sargeant", GivenName = "Logan", FamilyName = "Sargeant", PermanentNumber = 2, Nationality = "American", DateOfBirth = "2000-12-31", Url = "http://en.wikipedia.org/wiki/Logan_Sargeant" },
                new F1Driver { F1DriverId = "albon", GivenName = "Alexander", FamilyName = "Albon", PermanentNumber = 23, Nationality = "Thai", DateOfBirth = "1996-03-23", Url = "http://en.wikipedia.org/wiki/Alexander_Albon" },
                new F1Driver { F1DriverId = "de_vries", GivenName = "Nyck", FamilyName = "de Vries", PermanentNumber = 7, Nationality = "Dutch", DateOfBirth = "1995-02-06", Url = "http://en.wikipedia.org/wiki/Nyck_de_Vries" },
                new F1Driver { F1DriverId = "lawson", GivenName = "Liam", FamilyName = "Lawson", PermanentNumber = 36, Nationality = "New Zealander", DateOfBirth = "2002-02-11", Url = "http://en.wikipedia.org/wiki/Liam_Lawson" }
            );

            modelBuilder.Entity<Constructor>().HasData(
                new Constructor { ConstructorId = "alpine", ConstructorName = "Alpine F1 Team", Nationality = "French", Url = "http://en.wikipedia.org/wiki/Alpine_F1_Team", Driver1 ="Pierre Gasly", Driver2 = "Esteban Ocon" },
                new Constructor { ConstructorId = "aston_martin", ConstructorName = "Aston Martin", Nationality = "British", Url = "http://en.wikipedia.org/wiki/Aston_Martin_in_Formula_One", Driver1 = "Fernando Alonso", Driver2 = "Lance Stoll" },
                new Constructor { ConstructorId = "ferrari", ConstructorName = "Ferrari", Nationality = "Italian", Url = "http://en.wikipedia.org/wiki/Scuderia_Ferrari", Driver1 = "Charles Leclerc", Driver2 = "Carlos Sainz" },
                new Constructor { ConstructorId = "haas", ConstructorName = "Haas F1 Team", Nationality = "American", Url = "http://en.wikipedia.org/wiki/Haas_F1_Team", Driver1 = "Nico Hülkenberg", Driver2 = "Kevin Magnussen" },
                new Constructor { ConstructorId = "mclaren", ConstructorName = "McLaren", Nationality = "British", Url = "http://en.wikipedia.org/wiki/McLaren", Driver1 = "Lando Norris", Driver2 = "Oscar Piastri" },
                new Constructor { ConstructorId = "mercedes", ConstructorName = "Mercedes", Nationality = "German", Url = "http://en.wikipedia.org/wiki/Mercedes-Benz_in_Formula_One", Driver1 = "Lewis Hamilton", Driver2 = "George Russell" },
                new Constructor { ConstructorId = "rb", ConstructorName = "RB F1 Team", Nationality = "Italian", Url = "http://en.wikipedia.org/wiki/RB_Formula_One_Team", Driver1 = "Yuki Tsunoda", Driver2 = "Liam Lawson" },
                new Constructor { ConstructorId = "red_bull", ConstructorName = "Red Bull", Nationality = "Austrian", Url = "http://en.wikipedia.org/wiki/Red_Bull_Racing", Driver1 = "Max Verstappen", Driver2 = "Sergio Pérez" },
                new Constructor { ConstructorId = "sauber", ConstructorName = "Sauber", Nationality = "Swiss", Url = "http://en.wikipedia.org/wiki/Sauber_Motorsport", Driver1 = "Valtteri Bottas", Driver2 = "Guanyu Zhou" },
                new Constructor { ConstructorId = "williams", ConstructorName = "Williams", Nationality = "British", Url = "http://en.wikipedia.org/wiki/Williams_Grand_Prix_Engineering", Driver1 = "Alexander Albon", Driver2 = "Franco Colapinto" }
            );

            modelBuilder.Entity<Circuit>().HasData(
                new Circuit { CircuitId = "albert_park", CircuitName = "Albert Park Grand Prix Circuit", Locality = "Melbourne", Country = "Australia", Url = "http://en.wikipedia.org/wiki/Melbourne_Grand_Prix_Circuit" },
                new Circuit { CircuitId = "americas", CircuitName = "Circuit of the Americas", Locality = "Austin", Country = "USA", Url = "http://en.wikipedia.org/wiki/Circuit_of_the_Americas" },
                new Circuit { CircuitId = "bahrain", CircuitName = "Bahrain International Circuit", Locality = "Sakhir", Country = "Bahrain", Url = "http://en.wikipedia.org/wiki/Bahrain_International_Circuit" },
                new Circuit { CircuitId = "baku", CircuitName = "Baku City Circuit", Locality = "Baku", Country = "Azerbaijan", Url = "http://en.wikipedia.org/wiki/Baku_City_Circuit" },
                new Circuit { CircuitId = "catalunya", CircuitName = "Circuit de Barcelona-Catalunya", Locality = "Montmelo", Country = "Spain", Url = "http://en.wikipedia.org/wiki/Circuit_de_Barcelona-Catalunya" },
                new Circuit { CircuitId = "hungaroring", CircuitName = "Hungaroring", Locality = "Budapest", Country = "Hungary", Url = "http://en.wikipedia.org/wiki/Hungaroring" },
                new Circuit { CircuitId = "imola", CircuitName = "Autodromo Enzo e Dino Ferrari", Locality = "Imola", Country = "Italy", Url = "http://en.wikipedia.org/wiki/Autodromo_Enzo_e_Dino_Ferrari" },
                new Circuit { CircuitId = "interlagos", CircuitName = "Autodromo Jose Carlos Pace", Locality = "Sao Paulo", Country = "Brazil", Url = "http://en.wikipedia.org/wiki/Aut%C3%B3dromo_Jos%C3%A9_Carlos_Pace" },
                new Circuit { CircuitId = "jeddah", CircuitName = "Jeddah Corniche Circuit", Locality = "Jeddah", Country = "Saudi Arabia", Url = "http://en.wikipedia.org/wiki/Jeddah_Street_Circuit" },
                new Circuit { CircuitId = "losail", CircuitName = "Losail International Circuit", Locality = "Al Daayen", Country = "Qatar", Url="http://en.wikipedia.org/wiki/Losail_International_Circuit" },
                new Circuit { CircuitId = "marina_bay", CircuitName = "Marina Bay Street Circuit", Locality = "Marina Bay", Country = "Singapore", Url = "http://en.wikipedia.org/wiki/Marina_Bay_Street_Circuit" },
                new Circuit { CircuitId = "miami", CircuitName = "Miami International Autodrome", Locality = "Miami", Country = "USA", Url = "http://en.wikipedia.org/wiki/Miami_International_Autodrome" },
                new Circuit { CircuitId = "monaco", CircuitName = "Circuit de Monaco", Locality = "Monte Carlo", Country = "Monaco", Url = "http://en.wikipedia.org/wiki/Circuit_de_Monaco" },
                new Circuit { CircuitId = "monza", CircuitName = "Autodromo Nazionale di Monza", Locality = "Monza", Country = "Italy", Url = "http://en.wikipedia.org/wiki/Autodromo_Nazionale_Monza" },
                new Circuit { CircuitId = "red_bull_ring", CircuitName = "Red Bull Ring", Locality = "Spielberg", Country = "Austria", Url = "http://en.wikipedia.org/wiki/Red_Bull_Ring" },
                new Circuit { CircuitId = "ricard", CircuitName = "Circuit Paul Ricard", Locality = "Le Castellet", Country = "France", Url = "http://en.wikipedia.org/wiki/Paul_Ricard_Circuit" },
                new Circuit { CircuitId = "rodriguez", CircuitName = "Autodromo Hermanos Rodriguez", Locality = "Mexico City", Country = "Mexico", Url = "http://en.wikipedia.org/wiki/Aut%C3%B3dromo_Hermanos_Rodr%C3%ADguez" },
                new Circuit { CircuitId = "shanghai", CircuitName = "Shanghai International Circuit", Locality = "Shanghai", Country = "China", Url = "http://en.wikipedia.org/wiki/Shanghai_International_Circuit" },
                new Circuit { CircuitId = "silverstone", CircuitName = "Silverstone Circuit", Locality = "Silverstone", Country = "UK", Url = "http://en.wikipedia.org/wiki/Silverstone_Circuit" },
                new Circuit { CircuitId = "spa", CircuitName = "Circuit de Spa-Francorchamps", Locality = "Spa", Country = "Belgium", Url = "http://en.wikipedia.org/wiki/Circuit_de_Spa-Francorchamps" },
                new Circuit { CircuitId = "suzuka", CircuitName = "Suzuka Circuit", Locality = "Suzuka", Country = "Japan", Url = "http://en.wikipedia.org/wiki/Suzuka_Circuit" },
                new Circuit { CircuitId = "vegas", CircuitName = "Las Vegas Strip Street Circuit", Locality = "Las Vegas", Country = "USA", Url = "https://en.wikipedia.org/wiki/Las_Vegas_Grand_Prix#Circuit" },
                new Circuit { CircuitId = "villeneuve", CircuitName = "Circuit Gilles Villeneuve", Locality = "Montreal", Country = "Canada", Url = "http://en.wikipedia.org/wiki/Circuit_Gilles_Villeneuve" },
                new Circuit { CircuitId = "yas_marina", CircuitName = "Yas Marina Circuit", Locality = "Abu Dhabi", Country = "UAE", Url = "http://en.wikipedia.org/wiki/Yas_Marina_Circuit" },
                new Circuit { CircuitId = "zandvoort", CircuitName = "Circuit Zandvoort", Locality = "Zandvoort", Country = "Netherlands", Url = "http://en.wikipedia.org/wiki/Circuit_Zandvoort" }
            );
        }
    }
}