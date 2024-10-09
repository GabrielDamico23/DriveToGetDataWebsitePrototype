namespace DriveToGetDataWebsitePrototype.Models
{
    public class Location
    {
        public int LocationId { get; set; }
        public string Lat { get; set; } = string.Empty;
        public string Long { get; set; } = string.Empty;
        public string Locality { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
    }
}
