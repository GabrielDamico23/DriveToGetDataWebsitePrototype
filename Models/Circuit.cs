using System.ComponentModel.DataAnnotations;

namespace DriveToGetDataWebsitePrototype.Models
{
    public class Circuit
    {
        //these properties are selected from the Ergast API and will be populated using the GET request to http://ergast.com/api/f1/current/circuits
        [Required]
        public string CircuitId { get; set; } = string.Empty;
        [Required]
        public string CircuitName { get; set; } = string.Empty;
        [Required]
        public string Country { get; set; } = string.Empty;
        [Required]
        public string Locality { get; set; } = string.Empty;
        [Required]
        public string Url { get; set; } = string.Empty;
    }
}

