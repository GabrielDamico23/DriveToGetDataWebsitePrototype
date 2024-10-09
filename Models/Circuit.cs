using System.ComponentModel.DataAnnotations;

namespace DriveToGetDataWebsitePrototype.Models
{
    public class Circuit
    {
        public string CircuitId { get; set; } = string.Empty;
        public string CircuitName { get; set; } = string.Empty;
        //public Location? Location { get; set; } = null;
        public string Locality { get; set; } = string.Empty;
        [StringLength(30, MinimumLength = 3)]
        public string Country { get; set; } = string.Empty;
        public string Url { get; set; } = string.Empty;
    }
}
