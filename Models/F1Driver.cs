using System.ComponentModel.DataAnnotations;

namespace DriveToGetDataWebsitePrototype.Models
{
    public class F1Driver
    {
        //these properties are selected from the Ergast API and will be populated using the GET request to http://ergast.com/api/f1/current/drivers
        [Required]
        public string F1DriverId { get; set; } = string.Empty;
        [Required]
        public string GivenName { get; set; } = string.Empty;
        [Required]
        public string FamilyName { get; set; } = string.Empty;
        [Required]
        public int PermanentNumber { get; set; }
        [Required]
        public string Nationality { get; set; } = string.Empty;
        [Required]
        public string Url { get; set; } = string.Empty;
        [Required]
        public string DateOfBirth { get; set; } = string.Empty;
        
    }

}
