namespace DriveToGetDataWebsitePrototype.Services
{
    using System.Net.Http;
    using System.Net.Http.Json;
    using System.Threading.Tasks;
    using System.Collections.Generic;
    using Models;

    public class ErgastF1Service
    {
        private static HttpClient _httpClient;

        private static readonly string Ergast_url = "https://ergast.com/api/f1";

        public ErgastF1Service(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<ErgastDriver>> GetErgastDriversAsync()
        {
            var response = await _httpClient.GetFromJsonAsync<ErgastApiResponse>(Ergast_url+"/current/drivers.json");
            return response?.MRData?.DriverTable?.Drivers ?? new List<ErgastDriver>();
        }

        public async Task<List<ErgastConstructor>> GetErgastConstructorsAsync()
        {
            var response = await _httpClient.GetFromJsonAsync<ErgastApiResponse>(Ergast_url + "/current/constructors.json");
            return response?.MRData?.ConstructorTable?.Constructors ?? new List<ErgastConstructor>();
        }

        public class ErgastApiResponse
        {
            public ErgastMRData MRData { get; set; }
        }

        public class ErgastMRData
        {
            public DriverTable DriverTable { get; set; }
            public ConstructorTable ConstructorTable { get; set; }
        }

        public class DriverTable
        {
            public List<ErgastDriver> Drivers { get; set; }
        }

        public class ConstructorTable
        {
            public List<ErgastConstructor> Constructors { get; set; }
        }
    }

}
