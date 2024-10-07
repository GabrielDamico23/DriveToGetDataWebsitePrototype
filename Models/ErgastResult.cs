using System.Collections.Specialized;

namespace DriveToGetDataWebsitePrototype.Models
{
    public class ErgastResult
    {
        public string DriverId { get; set; }
        public string GivenName { get; set; }
        public string FamilyName { get; set; }
        public string Name { get; set; }
        public int Position { get; set; }
        public int Points { get; set; }
        public int Grid { get; set; }
        public int Laps { get; set; }
        public string Status { get; set; }
        public string FastestLapTime { get; set; }
        public int AverageSpeed { get; set; }

    }
}
