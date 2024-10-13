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
            var response = await _httpClient.GetFromJsonAsync<ErgastApiResponse>(Ergast_url + "/2024/drivers.json");
            return response?.MRData?.DriverTable?.Drivers ?? new List<Driver>();
        }

        //public async Task<List<Result>> GetErgastRaceResultsAsync()
        //{
        //    var response = await _httpClient.GetFromJsonAsync<ErgastApiResponse>(Ergast_url + "/2024.json");
        //    return response?.MRData?.RaceTable?.Race1?.Results ?? new List<Result>();
        //}

        //public async Task<List<Race>?> GetRaceResultsAsync(string driver)
        //{
        //    try
        //    {
        //        var response = await _httpClient.GetFromJsonAsync<ErgastApiResponse>(Ergast_url + $"/2024/1/drivers/{driver}/results.json");
        //        if (response.MRData == null)
        //        {
        //            Console.WriteLine("No response received.");
        //            return null;
        //        }
        //        return response?.MRData?.RaceTable?.Races?.Select(static r => new Race
        //        {
        //                    RaceName = r.RaceName,
        //                    ResultsLists = r.ResultsLists.Select(static resultList => new ResultsList
        //                    {
        //                        Position = resultList.Position,
        //                        Points = resultList.Points,
        //                        Grid = resultList.Grid,
        //                        Laps = resultList.Laps,
        //                        Status = resultList.Status,
        //                        Drivers = resultList.Drivers.Select(driver => new Driver
        //                        {
        //                            GivenName = driver.GivenName,
        //                            FamilyName = driver.FamilyName
        //                        }).ToList(),
        //                        FastestLaps = resultList.FastestLaps.Select(fastestLap => new FastestLap
        //                        {
        //                            Rank = fastestLap.Rank,
        //                            Time = fastestLap.Time
        //                        }).ToList()

        //                    }).ToList()
        //                }).ToList();
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine($"Error: {ex.Message}");
        //    }

        //    return null;
        //}


        public async Task<List<Race>?> GetRaceResultsAsync(string driver)
        {
            try
            {
                var response = await _httpClient.GetFromJsonAsync<ErgastApiResponse>(Ergast_url + $"/2024/drivers/{driver}/results.json");
                //return response?.MRData?.RaceTable?.Races ?? new List<Race>();


                return response.MRData.RaceTable.Races.Select(r => new Race
                {
                    RaceName = r.RaceName,
                    Round = r.Round,
                    Position = r.Position,
                    Points = r.Points,
                    Grid = r.Grid,
                    Laps = r.Laps,
                    Status = r.Status,
                    Drivers = r.Drivers.Select(driver => new Driver
                    {
                        GivenName = driver.GivenName,
                        FamilyName = driver.FamilyName
                    }).ToList(),
                    FastestLaps = r.FastestLaps.Select(fastestLap => new FastestLap
                    {
                        Rank = fastestLap.Rank,
                        Time = fastestLap.Time
                    }).ToList()
                }).ToList();

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            return null;
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
            //public Race Race1 { get; set; }
            public List<Race> Races { get; set; }

        }


        //public class Race1
        //{
        //    public List<Result> Results { get; set; }

        //}
    }
}
