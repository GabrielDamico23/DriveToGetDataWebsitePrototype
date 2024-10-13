namespace DriveToGetDataWebsitePrototype.Models
{
    public class Result
    {
        public int Position { get; set; }
        public int Points { get; set; }
        public int Grid { get; set; }
        public int Laps { get; set; }
        public string Status { get; set; } = string.Empty;
        public List<Driver> Drivers { get; set; }
        public List<FastestLap> FastestLaps { get; set; }
    }
}
