﻿namespace DriveToGetDataWebsitePrototype.Services
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

        public async Task<List<Race>> GetRaceResultsAsync(string driver)
        {
            try
            {
                var response = await _httpClient.GetFromJsonAsync<ErgastApiResponse>(Ergast_url + $"/2024/drivers/{driver}/results.json");
                //return response?.MRData?.RaceTable?.Races ?? new List<Race>();

                return response?.MRData?.RaceTable?.Races?.Select(r => new Race
                {
                    RaceName = r.RaceName,
                    Results = r.Results.Select(result => new Result
                    {
                        Position = result.Position,
                        Driver = new Driver
                        {
                            GivenName = result.Driver.GivenName,
                            FamilyName = result.Driver.FamilyName
                        },
                        Constructor = result.Constructor,
                        Points = result.Points,
                        Laps = result.Laps,
                        Status = result.Status,
                        //Time = result.Time != null ? ParseTime(result.Time) : null,
                        //Time = result.Time ?? "N/A"
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
            public List<Race> Races { get; set; }
        }

    }

}
