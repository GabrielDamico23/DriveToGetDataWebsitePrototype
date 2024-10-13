using System.Text.Json.Serialization;
using DriveToGetDataWebsitePrototype.Services;

namespace DriveToGetDataWebsitePrototype.Models
{
    public class Result
    {
        public string Position { get; set; }
        public Driver Driver { get; set; }
        public FastestLap FastestLap { get; set; }
        public string Constructor { get; set; }
        public int Points { get; set; }
        public int Laps { get; set; }
        public int Grid { get; set; }
        public string Status { get; set; }
    }

    public class FastestLap
    {
        public string Time { get; set; }
        public double? AverageSpeed { get; set; }
        public int? Rank { get; set; }
    }
}