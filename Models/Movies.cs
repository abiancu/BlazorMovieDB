using BlazorMovieDB.Data;

namespace BlazorMovieDB.Models;

public class MovieResults : IMediaResults
{
    public long Page { get; set; }
    public List<MoviesDto> Results { get; set; } = [];
    
    public long TotalPages { get; set; }
    
    public long TotalResults { get; set; }
}

public class Movie : IMedia
{
    public bool Adult { get; set; }

    public string BackdropPath { get; set; } = null!;

    public List<long> GenreIds { get; set; } = [];
    
    public long Id { get; set; }
    
    public string OriginalLanguage { get; set; } = null!;
    
    public string? OriginalTitle { get; set; }

    public string Overview { get; set; } = null!;

    public double Popularity { get; set; }

    public string PosterPath { get; set; } = null!;
    
    public DateTimeOffset ReleaseDate { get; set; }
    
    public string? Title { get; set; }
    
    public bool Video { get; set; }
    
    public double VoteAverage { get; set; }
    
    public long VoteCount { get; set; }
}

