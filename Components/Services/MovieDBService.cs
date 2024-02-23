using System.Net.Http.Headers;
using System.Text.Json;
using BlazorMovieDB.Models;
using BlazorMovieDB.Utilities;
using Newtonsoft.Json;


namespace BlazorMovieDB.Components.Services
{
    public class MovieDBService
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _config;
        private readonly string? _token;

        public MovieDBService(HttpClient httpClient, IConfiguration config)
        {
            _config = config;
            _httpClient = httpClient;
            _token = _config["TOKEN"] ?? throw new Exception("MDB token not found!");
            _httpClient.BaseAddress = new Uri(_config["MDB_URL"] ?? throw new Exception("MDB URL not"));
            _httpClient.DefaultRequestHeaders.Accept.Add(new("application/json"));
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _token);
        }

        public async Task<List<Movie>?> GetMoviesAsync()
        {
            try
            {
                
                var response = await _httpClient.SendAsync(new HttpRequestMessage(HttpMethod.Get,
                    $"{_httpClient.BaseAddress}/{Constants.discoverMovie}"));
                
                if (response.IsSuccessStatusCode)
                {
                    var body = await response.Content.ReadAsStringAsync();
                    var deserializedObject = JsonConvert.DeserializeObject<MovieResults>(body);
                    var movies = deserializedObject?.Results;
                  
                    return movies;
                }
                else
                {
                    return [];
                }
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
                
                if (response.IsSuccessStatusCode)
                {
                    var body = await response.Content.ReadAsStringAsync();
                    var deserializedObject = JsonConvert.DeserializeObject<TVResults>(body);
                    var listOfTv = deserializedObject?.Results;

                    return listOfTv;
                   

                }
                else
                {
                    return [];
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