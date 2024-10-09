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

        public async Task<List<Driver>> GetErgastDriversAsync()
        {
            var response = await _httpClient.GetFromJsonAsync<ErgastApiResponse>(Ergast_url+"/2024/drivers.json");
            return response?.MRData?.DriverTable?.Drivers ?? new List<Driver>();
        }

        public async Task<List<Result>> GetRaceResultsAsync(string driver, string round)
        {
            var response = await _httpClient.GetFromJsonAsync<ErgastApiResponse>(Ergast_url + "/2024/1/drivers/" + driver + "/" + round + "/results.json");
            return response?.MRData?.RaceTable?.Race?.Results ?? new List<Result>();
        }


        public class ErgastApiResponse
        {
            public ErgastMRData MRData { get; set; }
        }

        public class ErgastMRData
        {
            public DriverTable DriverTable { get; set; }
            public RaceTable RaceTable { get; set; }
        }

        public class DriverTable
        {
            public List<Driver> Drivers { get; set; }
        }

        public class RaceTable
        {
            //public ResultsList ResultsList { get; set; }
            //public List<ErgastRaceRound> RaceRounds { get; set; }
            public Race Race { get; set; }
        }


        //public class RaceSeason
        //{
        //    public RaceName RaceName { get; set; }
        //}

        //public class ResultsList
        //{
        //    public List<Result> Results { get; set; }
        //}

    }

}
