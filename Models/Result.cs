namespace DriveToGetDataWebsitePrototype.Models
{
    public class Result
    {
        public Driver Driver { get; set; }
        public string ConstructorName { get; set; }
        public int Position { get; set; }
        public int Points { get; set; }
        public int Grid { get; set; }
        public int Laps { get; set; }
        public string Status { get; set; }
   /// <summary>
   ///     public string Time { get; set; }
   /// </summary>

        
        public FastestLap FastestLap { get; set; }
    }

    public class FastestLap
    {
        public string? Time { get; set; }
        public double AverageSpeed { get; set; }
    }
}
