using Newtonsoft.Json;

namespace BlazorMovieDB.Data;

public class MoviesDto
{
    [JsonProperty("id")] public long Id { get; set; }
    [JsonProperty("title")] public string? Title { get; set; }
    [JsonProperty("poster_path")] public string PosterPath { get; set; } = null!;
}