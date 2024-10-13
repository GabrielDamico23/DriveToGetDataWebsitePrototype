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
        //public FastestLap FastestLap { get; set; }
        //public string FLTime => FastestLap.Time;
        //public int FLRank => FastestLap.Rank;


        // Using these leads to data conversion errors.

        //public string Time { get; set; }

        //public FastestLap FastestLap { get; set; }
    }

    public class FastestLap
    {
        public string Time { get; set; }
        public int Rank { get; set; }
        public double? AverageSpeed { get; set; }
    }
}
