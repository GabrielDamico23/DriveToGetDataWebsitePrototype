using DriveToGetDataWebsitePrototype.Services;

namespace DriveToGetDataWebsitePrototype.Models
{
    public class ResultsList
    {
            public List<Result> Results { get; set; }

        public static implicit operator ResultsList(ErgastF1Service.ResultsList v)
        {
            throw new NotImplementedException();
        }
    }
}
