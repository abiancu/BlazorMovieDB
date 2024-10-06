using BlazorMovieDB.Models;
using Newtonsoft.Json;

namespace BlazorMovieDB.Data;

public class MoviesDto : Movie
{
    [JsonProperty("id")] public new long Id { get; set; }
    [JsonProperty("title")] public new string? Title { get; set; }
    [JsonProperty("poster_path")] public new string PosterPath { get; set; } = null!;
}