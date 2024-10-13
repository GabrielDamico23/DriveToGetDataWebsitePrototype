namespace DriveToGetDataWebsitePrototype.Services
{
    using System.Net.Http;
    using System.Net.Http.Json;
    using System.Threading.Tasks;
    using System.Collections.Generic;
    using Models;
    using System.Diagnostics;
    using System.Text.Json;

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

        public async Task<List<Race1>> GetRaceResultsAsync(string driver)
        {
            try
            {
                var jsonResponse = await _httpClient.GetStringAsync(Ergast_url + $"/2024/1/drivers/{driver}/results.json");
                Debug.WriteLine($"Raw JSON Response: {jsonResponse}");

                var response = JsonSerializer.Deserialize<ErgastApiResponse>(jsonResponse);


                // Log the response for debugging
                Debug.WriteLine($"Response for driver {driver}: {response}");

                if (response?.MRData?.RaceTable?.Races == null || !response.MRData.RaceTable.Races.Any())
                {
                    Debug.WriteLine("No races found for the selected driver.");
                    return new List<Race1>(); // Return an empty list if no races found
                }

#pragma warning disable CS8604 // Possible null reference argument.
#pragma warning disable CS8601 // Possible null reference assignment.
                return response.MRData.RaceTable.Races
                    .Where(r => r != null)
                    .Select(r => new Race1
                    {
                        RaceName = r?.RaceName,
                        Round = (int)(r?.Round),
                        ResultsLists = r?.ResultsLists == null ? null : new ResultsList
                        {
                            Results = r.ResultsLists.Results?.Where(result => result != null).Select(result => new Result
                            {
                                Position = result?.Position,
                                Driver = result?.Driver == null ? null : new Driver
                                {
                                    GivenName = result.Driver?.GivenName,
                                    FamilyName = result.Driver?.FamilyName
                                },
                                FastestLap = result?.FastestLap == null ? null : new FastestLap
                                {
                                    Time = result.FastestLap?.Time,
                                    Rank = result.FastestLap?.Rank,
                                },
                                Constructor = result?.Constructor,
                                Points = (int)(result?.Points),
                                Laps = (int)(result?.Laps),
                                Grid = (int)(result?.Grid),
                                Status = result?.Status
                            }).ToList()
                        },
                    }).ToList();
#pragma warning restore CS8601 // Possible null reference assignment.
#pragma warning restore CS8604 // Possible null reference argument.
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error during API call: {ex.Message}");
                Debug.WriteLine(ex.StackTrace);
            }

            return new List<Race1>(); // Ensure it never returns null
        }



        public class ErgastApiResponse
        {
            public MRData MRData { get; set; }
        }

        public class MRData
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
            public List<Race1> Races { get; set; }
        }

        public class ResultsList
        {
            public List<Result> Results { get; set; }
        }

    }
}


