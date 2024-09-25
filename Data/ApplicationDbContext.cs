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
            modelBuilder.Entity<Driver>().ToTable("Driver");

            modelBuilder.Entity<Driver>().HasData(
                new Driver { DriverId = "hamilton", GivenName = "Lewis", FamilyName = "Hamilton", PermanentNumber = 44, Nationality = "British" },
                new Driver { DriverId = "bottas", GivenName = "Valtteri", FamilyName = "Bottas", PermanentNumber = 77, Nationality = "Finnish" },
                new Driver { DriverId = "verstappen", GivenName = "Max", FamilyName = "Verstappen", PermanentNumber = 33, Nationality = "Dutch" },
                new Driver { DriverId = "perez", GivenName = "Sergio", FamilyName = "Perez", PermanentNumber = 11, Nationality = "Mexican" },
                new Driver { DriverId = "norris", GivenName = "Lando", FamilyName = "Norris", PermanentNumber = 4, Nationality = "British" },
                new Driver { DriverId = "ricciardo", GivenName = "Daniel", FamilyName = "Ricciardo", PermanentNumber = 3, Nationality = "Australian" },
                new Driver { DriverId = "sainz", GivenName = "Carlos", FamilyName = "Sainz", PermanentNumber = 55, Nationality = "Spanish" },
                new Driver { DriverId = "leclerc", GivenName = "Charles", FamilyName = "Leclerc", PermanentNumber = 16, Nationality = "Monegasque" },
                new Driver { DriverId = "piastri", GivenName = "Oscar", FamilyName = "Piastri", PermanentNumber = 81, Nationality = "Australian" },
                new Driver { DriverId = "russell", GivenName = "George", FamilyName = "Russell", PermanentNumber = 63, Nationality = "British" }
            );
        }
    }
}
