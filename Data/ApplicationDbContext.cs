using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using DriveToGetDataWebsitePrototype.Models;

namespace DriveToGetDataWebsitePrototype.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Driver> Drivers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<Driver>().ToTable("Driver");
            modelBuilder.Entity<Constructor>().ToTable("Constructor");

            //modelBuilder.Entity<Driver>().HasData(
            //    new Driver { DriverId = "hamilton", GivenName = "Lewis", FamilyName = "Hamilton", PermanentNumber = 44, Nationality = "British" },
            //    new Driver { DriverId = "bottas", GivenName = "Valtteri", FamilyName = "Bottas", PermanentNumber = 77, Nationality = "Finnish" },
            //    new Driver { DriverId = "verstappen", GivenName = "Max", FamilyName = "Verstappen", PermanentNumber = 1, Nationality = "Dutch" },
            //    new Driver { DriverId = "perez", GivenName = "Sergio", FamilyName = "Perez", PermanentNumber = 11, Nationality = "Mexican" },
            //    new Driver { DriverId = "norris", GivenName = "Lando", FamilyName = "Norris", PermanentNumber = 4, Nationality = "British" },
            //    new Driver { DriverId = "ricciardo", GivenName = "Daniel", FamilyName = "Ricciardo", PermanentNumber = 3, Nationality = "Australian" },
            //    new Driver { DriverId = "sainz", GivenName = "Carlos", FamilyName = "Sainz", PermanentNumber = 55, Nationality = "Spanish" },
            //    new Driver { DriverId = "leclerc", GivenName = "Charles", FamilyName = "Leclerc", PermanentNumber = 16, Nationality = "Monegasque" },
            //    new Driver { DriverId = "piastri", GivenName = "Oscar", FamilyName = "Piastri", PermanentNumber = 81, Nationality = "Australian" },
            //    new Driver { DriverId = "russell", GivenName = "George", FamilyName = "Russell", PermanentNumber = 63, Nationality = "British" },
            //    new Driver { DriverId = "alonso", GivenName = "Fernando", FamilyName = "Alonso", PermanentNumber = 14, Nationality = "Spanish" },
            //    new Driver { DriverId = "ocon", GivenName = "Esteban", FamilyName = "Ocon", PermanentNumber = 31, Nationality = "French" },
            //    new Driver { DriverId = "hulkenberg", GivenName = "Nico", FamilyName = "Hulkenberg", PermanentNumber = 27, Nationality = "German" },
            //    new Driver { DriverId = "stroll", GivenName = "Lance", FamilyName = "Stroll", PermanentNumber = 18, Nationality = "Canadian" },
            //    new Driver { DriverId = "tsunoda", GivenName = "Yuki", FamilyName = "Tsunoda", PermanentNumber = 22, Nationality = "Japanese" },
            //    new Driver { DriverId = "gasly", GivenName = "Pierre", FamilyName = "Gasly", PermanentNumber = 10, Nationality  = "French" },
            //    new Driver { DriverId = "bearman", GivenName = "Oliver", FamilyName = "Bearman", PermanentNumber = 50, Nationality = "British" },
            //    new Driver { DriverId = "magnussen", GivenName = "Kevin", FamilyName = "Magnussen", PermanentNumber = 20, Nationality = "Danish" },
            //    new Driver { DriverId = "colapinto", GivenName = "Franco", FamilyName = "Colapinto", PermanentNumber = 43, Nationality = "Argentinian" },
            //    new Driver { DriverId = "schumacher", GivenName = "Mick", FamilyName = "Schumacher", PermanentNumber = 47, Nationality = "German" },
            //    new Driver { DriverId = "vettel", GivenName = "Sebastian", FamilyName = "Vettel", PermanentNumber = 5, Nationality = "German" },
            //    new Driver { DriverId = "latifi", GivenName = "Nicholas", FamilyName = "Latifi", PermanentNumber = 6, Nationality = "Canadian" },
            //    new Driver { DriverId = "Guanyu", GivenName = "Zhou", FamilyName = "Zhou", PermanentNumber = 24, Nationality = "Chinese"}, 
            //    new Driver { DriverId = "sargeant", GivenName = "Logan", FamilyName = "Sargeant", PermanentNumber = 2, Nationality = "American"},
            //    new Driver { DriverId = "albon", GivenName = "Alexander", FamilyName = "Albon", PermanentNumber = 23, Nationality = "Thai"},
            //    new Driver { DriverId = "deVries", GivenName = "Nyck", FamilyName = "de Vries", PermanentNumber = 7, Nationality = "Dutch"},
            //    new Driver { DriverId = "lawson", GivenName = "Liam", FamilyName = "Lawson", PermanentNumber = 36, Nationality = "New Zealander"}
            //);

            modelBuilder.Entity<Constructor>().HasData(
                new Constructor { ConstructorId = "alpine", ConstructorName = "Alpine F1 Team", Nationality = "French"},
                new Constructor { ConstructorId = "astone_martin", ConstructorName = "Aston Martin", Nationality = "British" },
                new Constructor { ConstructorId = "ferrari", ConstructorName = "Ferrari", Nationality = "Italian"},
                new Constructor { ConstructorId = "haas", ConstructorName = "Haas F1 Team", Nationality = "American"},
                new Constructor { ConstructorId = "mclaren", ConstructorName = "McLaren", Nationality = "British" },
                new Constructor { ConstructorId = "mercedes", ConstructorName = "Mercedes", Nationality = "German" },
                new Constructor { ConstructorId = "rb", ConstructorName = "RB F1 Team", Nationality = "Italian" },
                new Constructor { ConstructorId = "red_bull", ConstructorName = "Red Bull", Nationality = "Austrian" },
                new Constructor { ConstructorId = "sauber", ConstructorName = "Sauber", Nationality = "Swiss" },
                new Constructor { ConstructorId = "williams", ConstructorName = "Williams", Nationality = "British" }
            );
        }
    }
}
