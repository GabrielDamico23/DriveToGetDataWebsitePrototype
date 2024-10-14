namespace DriveToGetDataWebsitePrototype.Models
{
    public class RaceResult
    {
        public string RaceName { get; set; }
        public string CircuitName { get; set; }
        public string Date { get; set; }
        public List<Result> Results { get; set; }


        //public string Locality { get; set; }
        //public string Country { get; set; }
        //public string DriverName { get; set; }
        //public string ConstructorName { get; set; }
        //public int Position { get; set; }
        //public int Points { get; set; }
        //public int Grid { get; set; }
        //public int Laps { get; set; }
        //public string Status { get; set; }
        //public string FastestLapTime { get; set; }
        //public double AverageSpeed { get; set; }
    }
}