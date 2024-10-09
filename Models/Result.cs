namespace DriveToGetDataWebsitePrototype.Models
{
    public class Result
    {
        public Driver Driver { get; set; }
        public Constructor Constructor { get; set; }
        public int Position { get; set; }
        public int Points { get; set; }
        public int Grid { get; set; }
        public int Laps { get; set; }
        public string Status { get; set; }
        public FastestLap FastestLap { get; set; }
    }

    public class FastestLap
    {
        public TimeOnly Time { get; set; }
        public Double AverageSpeed { get; set; }
    }
}
