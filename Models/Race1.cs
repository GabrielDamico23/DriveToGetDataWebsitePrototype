using static DriveToGetDataWebsitePrototype.Services.ErgastF1Service;

namespace DriveToGetDataWebsitePrototype.Models
{
    public class Race1
    {
        public string RaceName { get; set; }
        public int Round { get; set; }
        public ResultsList ResultsLists { get; set; }
        public Circuit Circuit { get; set; }
    }
}
