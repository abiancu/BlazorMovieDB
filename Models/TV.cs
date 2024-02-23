// Generated by https://quicktype.io
using Newtonsoft.Json;

namespace BlazorMovieDB.Models;

public partial class TVResults
{
    [JsonProperty("page")]
    public long Page { get; set; }

    [JsonProperty("results")]
    public List<TV> Results { get; set; } = [];

    [JsonProperty("total_pages")]
    public long TotalPages { get; set; }

    [JsonProperty("total_results")]
    public long TotalResults { get; set; }
}

public partial class TV
{
    [JsonProperty("adult")]
    public bool Adult { get; set; }

    [JsonProperty("backdrop_path")]
    public string BackdropPath { get; set; }

    [JsonProperty("genre_ids")]
    public long[] GenreIds { get; set; }

    [JsonProperty("id")]
    public long Id { get; set; }

    [JsonProperty("origin_country")]
    public string[] OriginCountry { get; set; }

    [JsonProperty("original_language")]
    public string OriginalLanguage { get; set; }

    [JsonProperty("original_name")]
    public string OriginalName { get; set; }

    [JsonProperty("overview")]
    public string Overview { get; set; }

    [JsonProperty("popularity")]
    public double Popularity { get; set; }

    [JsonProperty("poster_path")]
    public string PosterPath { get; set; }

    [JsonProperty("first_air_date")]
    public DateTimeOffset FirstAirDate { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("vote_average")]
    public double VoteAverage { get; set; }

    [JsonProperty("vote_count")]
    public long VoteCount { get; set; }
}

   