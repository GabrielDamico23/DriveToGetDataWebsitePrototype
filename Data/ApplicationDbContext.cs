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
            modelBuilder.Entity<F1Driver>().ToTable("Driver");
            modelBuilder.Entity<Constructor>().ToTable("Constructor");
            modelBuilder.Entity<Circuit>().ToTable("Circuit");

            modelBuilder.Entity<F1Driver>().HasData(
                new F1Driver { F1DriverId = "hamilton", GivenName = "Lewis", FamilyName = "Hamilton", PermanentNumber = 44, Nationality = "British" },
                new F1Driver { F1DriverId = "bottas", GivenName = "Valtteri", FamilyName = "Bottas", PermanentNumber = 77, Nationality = "Finnish" },
                new F1Driver { F1DriverId = "verstappen", GivenName = "Max", FamilyName = "Verstappen", PermanentNumber = 1, Nationality = "Dutch" },
                new F1Driver { F1DriverId = "perez", GivenName = "Sergio", FamilyName = "Perez", PermanentNumber = 11, Nationality = "Mexican" },
                new F1Driver { F1DriverId = "norris", GivenName = "Lando", FamilyName = "Norris", PermanentNumber = 4, Nationality = "British" },
                new F1Driver { F1DriverId = "ricciardo", GivenName = "Daniel", FamilyName = "Ricciardo", PermanentNumber = 3, Nationality = "Australian" },
                new F1Driver { F1DriverId = "sainz", GivenName = "Carlos", FamilyName = "Sainz", PermanentNumber = 55, Nationality = "Spanish" },
                new F1Driver { F1DriverId = "leclerc", GivenName = "Charles", FamilyName = "Leclerc", PermanentNumber = 16, Nationality = "Monegasque" },
                new F1Driver { F1DriverId = "piastri", GivenName = "Oscar", FamilyName = "Piastri", PermanentNumber = 81, Nationality = "Australian" },
                new F1Driver { F1DriverId = "russell", GivenName = "George", FamilyName = "Russell", PermanentNumber = 63, Nationality = "British" },
                new F1Driver { F1DriverId = "alonso", GivenName = "Fernando", FamilyName = "Alonso", PermanentNumber = 14, Nationality = "Spanish" },
                new F1Driver { F1DriverId = "ocon", GivenName = "Esteban", FamilyName = "Ocon", PermanentNumber = 31, Nationality = "French" },
                new F1Driver { F1DriverId = "hulkenberg", GivenName = "Nico", FamilyName = "Hulkenberg", PermanentNumber = 27, Nationality = "German" },
                new F1Driver { F1DriverId = "stroll", GivenName = "Lance", FamilyName = "Stroll", PermanentNumber = 18, Nationality = "Canadian" },
                new F1Driver { F1DriverId = "tsunoda", GivenName = "Yuki", FamilyName = "Tsunoda", PermanentNumber = 22, Nationality = "Japanese" },
                new F1Driver { F1DriverId = "gasly", GivenName = "Pierre", FamilyName = "Gasly", PermanentNumber = 10, Nationality = "French" },
                new F1Driver { F1DriverId = "bearman", GivenName = "Oliver", FamilyName = "Bearman", PermanentNumber = 50, Nationality = "British" },
                new F1Driver { F1DriverId = "magnussen", GivenName = "Kevin", FamilyName = "Magnussen", PermanentNumber = 20, Nationality = "Danish" },
                new F1Driver { F1DriverId = "colapinto", GivenName = "Franco", FamilyName = "Colapinto", PermanentNumber = 43, Nationality = "Argentinian" },
                new F1Driver { F1DriverId = "schumacher", GivenName = "Mick", FamilyName = "Schumacher", PermanentNumber = 47, Nationality = "German" },
                new F1Driver { F1DriverId = "vettel", GivenName = "Sebastian", FamilyName = "Vettel", PermanentNumber = 5, Nationality = "German" },
                new F1Driver { F1DriverId = "latifi", GivenName = "Nicholas", FamilyName = "Latifi", PermanentNumber = 6, Nationality = "Canadian" },
                new F1Driver { F1DriverId = "Guanyu", GivenName = "Zhou", FamilyName = "Zhou", PermanentNumber = 24, Nationality = "Chinese" },
                new F1Driver { F1DriverId = "sargeant", GivenName = "Logan", FamilyName = "Sargeant", PermanentNumber = 2, Nationality = "American" },
                new F1Driver { F1DriverId = "albon", GivenName = "Alexander", FamilyName = "Albon", PermanentNumber = 23, Nationality = "Thai" },
                new F1Driver { F1DriverId = "deVries", GivenName = "Nyck", FamilyName = "de Vries", PermanentNumber = 7, Nationality = "Dutch" },
                new F1Driver { F1DriverId = "lawson", GivenName = "Liam", FamilyName = "Lawson", PermanentNumber = 36, Nationality = "New Zealander" }
            );

            modelBuilder.Entity<Constructor>().HasData(
                new Constructor { ConstructorId = "alpine", ConstructorName = "Alpine F1 Team", Nationality = "French" },
                new Constructor { ConstructorId = "astone_martin", ConstructorName = "Aston Martin", Nationality = "British" },
                new Constructor { ConstructorId = "ferrari", ConstructorName = "Ferrari", Nationality = "Italian" },
                new Constructor { ConstructorId = "haas", ConstructorName = "Haas F1 Team", Nationality = "American" },
                new Constructor { ConstructorId = "mclaren", ConstructorName = "McLaren", Nationality = "British" },
                new Constructor { ConstructorId = "mercedes", ConstructorName = "Mercedes", Nationality = "German" },
                new Constructor { ConstructorId = "rb", ConstructorName = "RB F1 Team", Nationality = "Italian" },
                new Constructor { ConstructorId = "red_bull", ConstructorName = "Red Bull", Nationality = "Austrian" },
                new Constructor { ConstructorId = "sauber", ConstructorName = "Sauber", Nationality = "Swiss" },
                new Constructor { ConstructorId = "williams", ConstructorName = "Williams", Nationality = "British" }
            );

            modelBuilder.Entity<Circuit>().HasData(
                new Circuit { CircuitId = "albert_park", CircuitName = "Albert Park Grand Prix Circuit",  Locality = "Melbourne", Country = "Australia"},
                new Circuit { CircuitId = "americas", CircuitName = "Circuit of the Americas", Locality = "Austin", Country = "USA" },
                new Circuit { CircuitId = "bahrain", CircuitName = "Bahrain International Circuit", Locality = "Sakhir", Country = "Bahrain" },
                new Circuit { CircuitId = "baku", CircuitName = "Baku City Circuit", Locality = "Baku", Country = "Azerbaijan" },
                new Circuit { CircuitId = "catalunya", CircuitName = "Circuit de Barcelona-Catalunya", Locality = "Montmelo", Country = "Spain" },
                new Circuit { CircuitId = "hungaroring", CircuitName = "Hungaroring", Locality = "Budapest", Country = "Hungary" },
                new Circuit { CircuitId = "imola", CircuitName = "Autodromo Enzo e Dino Ferrari", Locality = "Imola", Country = "Italy" },
                new Circuit { CircuitId = "interlagos", CircuitName = "Autodromo Jose Carlos Pace", Locality = "Sao Paulo", Country = "Brazil" },
                new Circuit { CircuitId = "jeddah", CircuitName = "Jeddah Corniche Circuit", Locality = "Jeddah", Country = "Saudi Arabia" },
                new Circuit { CircuitId = "losail", CircuitName = "Losail International Circuit", Locality = "Al Daayen", Country = "Qatar"},
                new Circuit { CircuitId = "marina_bay", CircuitName = "Marina Bay Street Circuit", Locality = "Marina Bay", Country = "Singapore" },
                new Circuit { CircuitId = "miami", CircuitName = "Miami International Autodrome", Locality = "Miami", Country = "USA" },
                new Circuit { CircuitId = "monaco", CircuitName = "Circuit de Monaco", Locality = "Monte Carlo", Country = "Monaco" },
                new Circuit { CircuitId = "monza", CircuitName = "Autodromo Nazionale di Monza", Locality = "Monza", Country = "Italy" },
                new Circuit { CircuitId = "red_bull_ring", CircuitName = "Red Bull Ring", Locality = "Spielberg", Country = "Austria" },
                new Circuit { CircuitId = "ricard", CircuitName = "Circuit Paul Ricard", Locality = "Le Castellet", Country = "France" },
                new Circuit { CircuitId = "rodriguez", CircuitName = "Autodromo Hermanos Rodriguez", Locality = "Mexico City", Country = "Mexico" },
                new Circuit { CircuitId = "shanghai", CircuitName = "Shanghai International Circuit", Locality = "Shanghai", Country = "China" },
                new Circuit { CircuitId = "silverstone", CircuitName = "Silverstone Circuit", Locality = "Silverstone", Country = "UK" },
                new Circuit { CircuitId = "spa", CircuitName = "Circuit de Spa-Francorchamps", Locality = "Spa", Country = "Belgium" },
                new Circuit { CircuitId = "suzuka", CircuitName = "Suzuka Circuit", Locality = "Suzuka", Country = "Japan" },
                new Circuit { CircuitId = "vegas", CircuitName = "Las Vegas Strip Street Circuit", Locality = "Las Vegas", Country = "USA" },
                new Circuit { CircuitId = "villeneuve", CircuitName = "Circuit Gilles Villeneuve", Locality = "Montreal", Country = "Canada" },
                new Circuit { CircuitId = "yas_marina", CircuitName = "Yas Marina Circuit", Locality = "Abu Dhabi", Country = "UAE" },
                new Circuit { CircuitId = "zandvoort", CircuitName = "Circuit Zandvoort", Locality = "Zandvoort", Country = "Netherlands" }
            );
        }
    }
}
