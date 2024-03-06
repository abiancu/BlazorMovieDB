using Newtonsoft.Json;

namespace BlazorMovieDB.Models;

public class TvDetails : IDetailsPage
{
    [JsonProperty("adult")] public bool Adult { get; set; }

    [JsonProperty("backdrop_path")] public string? BackdropPath { get; set; }

    [JsonProperty("created_by")] public CreatedBy[] CreatedBy { get; set; } = null!;

    [JsonProperty("episode_run_time")] public long[] EpisodeRunTime { get; set; } = null!;

    [JsonProperty("first_air_date")] public DateTimeOffset FirstAirDate { get; set; }

    [JsonProperty("genres")] public List<Genres>? Genres { get; set; } = [];

    [JsonProperty("homepage")] public Uri? Homepage { get; set; }

    [JsonProperty("id")] public long Id { get; set; }

    [JsonProperty("in_production")] public bool InProduction { get; set; }

    [JsonProperty("languages")] public string[]? Languages { get; set; }

    [JsonProperty("last_air_date")] public DateTimeOffset LastAirDate { get; set; }

    [JsonProperty("last_episode_to_air")] public EpisodeToAir LasEpisodeToAir { get; set; } = new();

    [JsonProperty("name")] public string Name { get; set; } = null!;

    [JsonProperty("next_episode_to_air")] public EpisodeToAir NexEpisodeToAir { get; set; } = new();

    [JsonProperty("networks")] public Network[] Networks { get; set; } = [];

    [JsonProperty("number_of_episodes")] public long NumberOfEpisodes { get; set; }

    [JsonProperty("number_of_seasons")] public long NumberOfSeasons { get; set; }

    [JsonProperty("origin_country")] public string[] OriginCountry { get; set; } = null!;

    [JsonProperty("original_language")] public string? OriginalLanguage { get; set; }

    [JsonProperty("original_name")] public string OriginalName { get; set; } = null!;

    [JsonProperty("overview")] public string? Overview { get; set; }

    [JsonProperty("popularity")] public double Popularity { get; set; }

    [JsonProperty("poster_path")] public string? PosterPath { get; set; }

    [JsonProperty("production_companies")] public Network[] ProductionCompanies { get; set; } = [];

    [JsonProperty("production_countries")] public List<ProductionCountries>? ProductionCountries { get; set; } = [];

    [JsonProperty("seasons")] public Season[] Seasons { get; set; } = [];

    [JsonProperty("spoken_languages")] public List<SpokenLanguages> SpokenLanguages { get; set; } = [];

    [JsonProperty("status")] public string? Status { get; set; }

    [JsonProperty("tagline")] public string? Tagline { get; set; }

    [JsonProperty("type")] public string Type { get; set; } = null!;

    [JsonProperty("vote_average")] public double VoteAverage { get; set; }

    [JsonProperty("vote_count")] public long VoteCount { get; set; }
}

public class CreatedBy
{
    [JsonProperty("id")] public long Id { get; set; }

    [JsonProperty("credit_id")] public string CreditId { get; set; } = null!;

    [JsonProperty("name")] public string Name { get; set; } = null!;

    [JsonProperty("gender")] public long Gender { get; set; }

    [JsonProperty("profile_path")] public object ProfilePath { get; set; } = null!;
}

public class Genres
{
    [JsonProperty("id")] public long Id { get; set; }

    [JsonProperty("name")] public string Name { get; set; } = null!;
}

public class EpisodeToAir
{
    [JsonProperty("id")] public long Id { get; set; }

    [JsonProperty("name")] public string Name { get; set; } = null!;

    [JsonProperty("overview")] public string Overview { get; set; } = null!;

    [JsonProperty("vote_average")] public double VoteAverage { get; set; }

    [JsonProperty("vote_count")] public long VoteCount { get; set; }

    [JsonProperty("air_date")] public DateTimeOffset AirDate { get; set; }

    [JsonProperty("episode_number")] public long EpisodeNumber { get; set; }

    [JsonProperty("episode_type")] public string EpisodeType { get; set; } = null!;

    [JsonProperty("production_code")] public string ProductionCode { get; set; } = null!;

    [JsonProperty("runtime")] public long? Runtime { get; set; }

    [JsonProperty("season_number")] public long SeasonNumber { get; set; }

    [JsonProperty("show_id")] public long ShowId { get; set; }

    [JsonProperty("still_path")] public string StillPath { get; set; } = null!;
}

public class Network
{
    [JsonProperty("id")] public long Id { get; set; }

    [JsonProperty("logo_path")] public string LogoPath { get; set; } = null!;

    [JsonProperty("name")] public string Name { get; set; } = null!;

    [JsonProperty("origin_country")] public string OriginCountry { get; set; } = null!;
}

public class ProductionCountries
{
    [JsonProperty("iso_3166_1")] public string Iso31661 { get; set; } = null!;

    [JsonProperty("name")] public string Name { get; set; } = null!;
}

public class Season
{
    [JsonProperty("air_date")] public DateTimeOffset? AirDate { get; set; }

    [JsonProperty("episode_count")] public long EpisodeCount { get; set; }

    [JsonProperty("id")] public long Id { get; set; }

    [JsonProperty("name")] public string Name { get; set; } = null!;

    [JsonProperty("overview")] public string Overview { get; set; } = null!;

    [JsonProperty("poster_path")] public string? PosterPath { get; set; }

    [JsonProperty("season_number")] public long SeasonNumber { get; set; }

    [JsonProperty("vote_average")] public double VoteAverage { get; set; }
}

public class SpokenLanguages
{
    [JsonProperty("english_name")] public string EnglishName { get; set; } = null!;

    [JsonProperty("iso_639_1")] public string Iso6391 { get; set; } = null!;

    [JsonProperty("name")] public string Name { get; set; } = null!;
}