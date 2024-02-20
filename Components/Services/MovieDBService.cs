using System.Text.Json;
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
            _httpClient.BaseAddress = new Uri(_config["MDB_URL"] ?? throw new Exception("MDB URL not"));
            _httpClient.DefaultRequestHeaders.Accept.Add(new("application/json"));
            _apiKey = _config["API_KEY"] ?? throw new Exception("MDB Key not found!");
        }

        public async Task<List<MovieResult>> GetMoviesAsync()
        {
            try
            {
                var response =
                    await _httpClient.GetFromJsonAsync<Movie>(
                        $"{_httpClient.BaseAddress}/{Constants.discoverMovie}?api_key={_apiKey}");
                if (response.Results is not null)
                {
                    List<MovieResult> movies = [];
                    movies = response.Results;
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

        public async Task<List<TVResults>> GetTvAsync()
        {
            try
            {
                var response =
                    await _httpClient.GetFromJsonAsync<TV>(
                        $"{_httpClient.BaseAddress}/{Constants.discoverTv}?api_key={_apiKey}");
                if (response is not null)
                {
                    List<TVResults> listOfTv = [];
                    listOfTv = response.Results.ConvertAll(tv => (TVResults)tv);

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