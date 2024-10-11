using System.ComponentModel.DataAnnotations;

namespace DriveToGetDataWebsitePrototype.Models
{
    public class Constructor
    {
        //these properties are selected from the Ergast API and will be populated using the GET request to http://ergast.com/api/f1/current/constructors
        [Required]
        public string ConstructorId { get; set; } = string.Empty;
        [Required]
        public string ConstructorName { get; set; } = string.Empty;
        [Required]
        public string Nationality { get; set; } = string.Empty;
        [Required]
        public string Url { get; set; } = string.Empty;
        [Required]
        //the below properties are selected from the Ergast API and will be populated using the GET request to http://ergast.com/api/f1/current/constructor/{constructorId}/drivers
        public string Driver1 { get; set; } = string.Empty;
        [Required]
        public string Driver2 { get; set; } = string.Empty;

    }
}

