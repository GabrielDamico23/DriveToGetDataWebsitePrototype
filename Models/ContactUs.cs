using System.ComponentModel.DataAnnotations;

namespace DriveToGetDataWebsitePrototype.Models
{
    public class ContactUs
    {
        [Key] [Required] 
        public int FormId { get; set; }
        [Required]
        public string Email { get; set; } = string.Empty;
        [Required]
        public string Message { get; set; } = string.Empty;
    }
}



