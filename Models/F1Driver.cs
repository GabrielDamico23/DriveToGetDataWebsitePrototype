using System.ComponentModel.DataAnnotations;

namespace DriveToGetDataWebsitePrototype.Models
{
    public class F1Driver
    {

        public string F1DriverId { get; set; } = string.Empty;
        [Required]
        public string GivenName { get; set; } = string.Empty;
        public string FamilyName { get; set; } = string.Empty;
        public int PermanentNumber { get; set; } 
        public string Nationality { get; set; } = string.Empty;
        public string ?Image {get; set; } = string.Empty;
    }

}
