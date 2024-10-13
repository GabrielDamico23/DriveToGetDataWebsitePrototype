
namespace DriveToGetDataWebsitePrototype.Models
{
    public class ResultsList
    {
        //public Result Results { get; set; }
        //public List<Result> Results { get; set; }
        List<Result> Results = new List<Result>();

        internal object Select(Func<object, Result> value)
        {
            throw new NotImplementedException();
        }
    }
}
