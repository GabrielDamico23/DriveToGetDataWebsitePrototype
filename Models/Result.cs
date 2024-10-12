﻿namespace DriveToGetDataWebsitePrototype.Models
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
        
        // Using these leads to data conversion errors.
        
        //public string Time { get; set; }
        //public TimeSpan? ParsedTime
        //{
        //    get
        //    {
        //        if (Time != null && TimeSpan.TryParse(Time, out TimeSpan result))
        //        {
        //            return result; // Return parsed TimeSpan if valid
        //        }
        //        return null; // Return null if Time is not valid (e.g., "DNF")
        //    }
        //}

        //public string Millis { get; set; }

        public FastestLap FastestLap { get; set; }
    }

    public class FastestLap
    {
        public string Time { get; set; }
        public double? AverageSpeed { get; set; }
    }
}
