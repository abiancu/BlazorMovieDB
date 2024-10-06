using BlazorMovieDB.Data;
using Newtonsoft.Json;

namespace BlazorMovieDB.Models;

public class TvResults : IMediaResults
{
    public long Page { get; set; }
    
    public List<TvDto> Results { get; set; } = [];
    
    public long TotalPages { get; set; }
    
    public long TotalResults { get; set; }
}

public class Tv : IMedia
{
    public bool Adult { get; set; }
    
    public string BackdropPath { get; set; } = null!;
    
    public List<long> GenreIds { get; set; } = [];
    public long Id { get; set; }
    
    public List<string> OriginCountry { get; set; } = [];
    
    public string OriginalLanguage { get; set; } = null!;
    
    public string? OriginalName { get; set; }
    
    public string Overview { get; set; } = null!;
    
    public double Popularity { get; set; }
    public string PosterPath { get; set; } = null!;
    
    public DateTimeOffset FirstAirDate { get; set; }
    public string? Name { get; set; }
    
    public double VoteAverage { get; set; }
    
    public long VoteCount { get; set; }
}

   
