namespace DriveToGetDataWebsitePrototype.Models
{
    /// <summary>
    /// This does not match the API which has a Name property.
    /// and no Driver1 or Driver2 properties.
    /// </summary>
    public class Constructor
    {
        public string ConstructorId { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Nationality { get; set; } = string.Empty;
        public string Url { get; set; } = string.Empty;
        public string Driver1 { get; set; } = string.Empty;
        public string Driver2 { get; set; } = string.Empty;

    }
}
