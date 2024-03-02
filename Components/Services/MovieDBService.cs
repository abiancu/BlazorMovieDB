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
                    $"{_httpClient.BaseAddress}/{Constants.DiscoverMovie}"));

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


        public async Task<List<Tv>?> GetTvAsync()
        {
            try
            {
                var response = await _httpClient.SendAsync(new HttpRequestMessage(HttpMethod.Get,
                    $"{_httpClient.BaseAddress}/{Constants.DiscoverTv}"));

                if (!response.IsSuccessStatusCode) return [];
                var body = await response.Content.ReadAsStringAsync();
                var deserializedObject = JsonConvert.DeserializeObject<TvResults>(body);
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
                    $"{_httpClient.BaseAddress}/{Constants.MovieDetails}/{id}"));
                
                if (response.IsSuccessStatusCode)
                {
                    var body = await response.Content.ReadAsStringAsync();
                    var deserializedObject = JsonConvert.DeserializeObject<MovieDetails>(body);
                    var movieDetails = deserializedObject;

                    return movieDetails;
                   

                }

                return new();
            }
            catch (HttpRequestException ex)
            {

                // _logger.LogError(ex.ToString());

                throw new HttpRequestException(ex.ToString());
            }
        }

        public async Task<TvDetails?> GetTvDetailsAsync(long id)
        {
            try
            {
                var response = await _httpClient.SendAsync(new HttpRequestMessage(HttpMethod.Get,
                    $"{_httpClient.BaseAddress}/{Constants.TvShowDetails}/{id}"));

                if (!response.IsSuccessStatusCode) return new();
                var body = await response.Content.ReadAsStringAsync();
                dynamic? details = JsonConvert.DeserializeObject<TvDetails>(body);

                return details;

            }
            catch (HttpRequestException e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}