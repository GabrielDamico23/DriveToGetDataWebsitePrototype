using System.Diagnostics;

namespace DriveToGetDataWebsitePrototype.Models
{
    public class Race
    {
        //public int Season { get; set; }
        //public int Round { get; set; }
        public string RaceName { get; set; }
        public Circuit Circuit { get; set; }
        public int Round { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }

        public double duration { get; set; }

        public List<Result> Results { get; set; }

    }
}