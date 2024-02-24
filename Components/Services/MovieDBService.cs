using System.Net.Http.Headers;
using BlazorMovieDB.Models;
using BlazorMovieDB.Utilities;
using Newtonsoft.Json;


namespace BlazorMovieDB.Components.Services
{
    public class MovieDbService
    {
        private readonly HttpClient _httpClient;
        public MovieDbService(HttpClient httpClient, IConfiguration config)
        {   
            var token = config["TOKEN"] ?? throw new Exception("MDB token not found!");
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri(config["MDB_URL"] ?? throw new Exception("MDB URL not"));
            _httpClient.DefaultRequestHeaders.Accept.Add(new("application/json"));
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
        }

        public async Task<List<Movie>?> GetMoviesAsync()
        {
            try
            {
                
                var response = await _httpClient.SendAsync(new HttpRequestMessage(HttpMethod.Get,
                    $"{_httpClient.BaseAddress}/{Constants.discoverMovie}"));

                if (!response.IsSuccessStatusCode) return [];
                var body = await response.Content.ReadAsStringAsync();
                var deserializedObject = JsonConvert.DeserializeObject<MovieResults>(body);
                var movies = deserializedObject?.Results;
                  
                return movies;

            }
            catch (HttpRequestException ex)
            {

                // _logger.LogError(ex.ToString());
                throw new HttpRequestException(ex.ToString());
            }
        }


        public async Task<List<TV>?> GetTvAsync()
        {
            try
            {
                var response = await _httpClient.SendAsync(new HttpRequestMessage(HttpMethod.Get,
                    $"{_httpClient.BaseAddress}/{Constants.discoverTv}"));

                if (!response.IsSuccessStatusCode) return [];
                var body = await response.Content.ReadAsStringAsync();
                var deserializedObject = JsonConvert.DeserializeObject<TVResults>(body);
                var listOfTv = deserializedObject?.Results;

                return listOfTv;

            }
            catch (HttpRequestException ex)
            {

                // _logger.LogError(ex.ToString());

                throw new HttpRequestException(ex.ToString());
            }
        }
        
        public async Task<MovieDetails?> GetMovieDetails(long id)
        {
            try
            {
                var response = await _httpClient.SendAsync(new HttpRequestMessage(HttpMethod.Get,
                    $"{_httpClient.BaseAddress}/{Constants.movieDetails}/{id}"));
                
                if (response.IsSuccessStatusCode)
                {
                    var body = await response.Content.ReadAsStringAsync();
                    var deserializedObject = JsonConvert.DeserializeObject<MovieDetails>(body);
                    var movieDetails = deserializedObject;

                    return movieDetails;
                   

                }
                else
                {
                    return new();
                }
            }
            catch (HttpRequestException ex)
            {

                // _logger.LogError(ex.ToString());

                throw new HttpRequestException(ex.ToString());
            }
        }
    }
}