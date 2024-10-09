namespace DriveToGetDataWebsitePrototype.Models
{
    public class ErgastResult
    {
        // The first 3 properties should be replaced by a single property called "Driver" of type Driver
        public string DriverId { get; set; }
        public string GivenName { get; set; }
        public string FamilyName { get; set; }
        
        // The next property should be replaced by a single property called "Constructor" of type Constructor
        public string Name { get; set; }
        // These properties are direct properties of the a Result
        public int Position { get; set; }
        public int Points { get; set; }
        public int Grid { get; set; }
        public int Laps { get; set; }
        public string Status { get; set; }
        // These 2 properties should be replaced by a single property called FastestLap
        public string FastestLapTime { get; set; }
        public int AverageSpeed { get; set; }

    }
}
