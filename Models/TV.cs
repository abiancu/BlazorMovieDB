// Generated by https://quicktype.io
using Newtonsoft.Json;

namespace BlazorMovieDB.Models;

public class TvResults : IMediaResults
{
    [JsonProperty("page")]
    public long Page { get; set; }
    
    [JsonProperty("results")]
    public List<Tv> Results { get; set; } = [];
    
    [JsonProperty("total_pages")]
    public long TotalPages { get; set; }

    [JsonProperty("total_results")]
    public long TotalResults { get; set; }
}

public class Tv : IMedia
{
    [JsonProperty("adult")]
    public bool Adult { get; set; }

    [JsonProperty("backdrop_path")] public string BackdropPath { get; set; } = null!;

    [JsonProperty("genre_ids")]
    public List<long> GenreIds { get; set; } = [];

    [JsonProperty("id")]
    public long Id { get; set; }

    [JsonProperty("origin_country")]
    public List<string> OriginCountry { get; set; } = []; 
    
    [JsonProperty("original_language")] public string OriginalLanguage { get; set; } = null!;

    [JsonProperty("original_name")]
    public string? OriginalName { get; set; }

    [JsonProperty("overview")] public string Overview { get; set; } = null!;

    [JsonProperty("popularity")]
    public double Popularity { get; set; }

    [JsonProperty("poster_path")] public string PosterPath { get; set; } = null!;

    [JsonProperty("first_air_date")]
    public DateTimeOffset FirstAirDate { get; set; }

    [JsonProperty("name")]
    public string? Name { get; set; }

    [JsonProperty("vote_average")]
    public double VoteAverage { get; set; }

    [JsonProperty("vote_count")]
    public long VoteCount { get; set; }
}

   
