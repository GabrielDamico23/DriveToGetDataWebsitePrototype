using System.ComponentModel.DataAnnotations;

namespace DriveToGetDataWebsitePrototype.Models
{
    public class Driver
    {
        public string DriverId { get; set; } = string.Empty;
        public string GivenName { get; set; } = string.Empty;
        public string FamilyName { get; set; } = string.Empty;
        public int PermanentNumber { get; set; } 
        public string Nationality { get; set; } = string.Empty;
        public string Url { get; set; } = string.Empty;
        public string DateOfBirth { get; set; } = string.Empty;
    }

}
