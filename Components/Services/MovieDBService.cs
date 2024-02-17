using BlazorMovieDB.Models;
using BlazorMovieDB.Utilities;

namespace BlazorMovieDB.Components.Services
{
    public class MovieDBService
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _config;
        private readonly string? _apiKey;

        public MovieDBService(HttpClient httpClient, IConfiguration config)
        {
            _config = config;
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri(_config["Mdb_Url"]);
            _httpClient.DefaultRequestHeaders.Accept.Add(new("application/json"));
            _apiKey = _config["API_KEY"] ?? throw new Exception("MDB Key not found!");
        }

        public async Task<Movies> GetMovies()
        {
            try
            {
               
               Movies? response =  await _httpClient.GetFromJsonAsync<Movies>($"{_httpClient.BaseAddress}/{Constants.discoverMovie}?api_key={_apiKey}");
               System.Diagnostics.Debug.WriteLine(response);
               return response;
                
            }
            catch (HttpRequestException ex)
            {
                throw new Exception(ex.ToString());
            }

        }
    }
}