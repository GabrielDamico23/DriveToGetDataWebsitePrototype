using System.ComponentModel.DataAnnotations;

namespace DriveToGetDataWebsitePrototype.Models
{
    public class ContactUs
    {
        [Key] public int FormId { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
    }
}
