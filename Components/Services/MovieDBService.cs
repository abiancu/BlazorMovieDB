using System.Net.Http.Json;
using BlazorMovieDB.Models;

namespace BlazorMovieDB.Services
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
    }
}