namespace BlazorMovieDB.Models;

public class MovieDetails
{
    public Dates Dates { get; set; } = new Dates();
    public int Page { get; set; }
    public Results[]? Results { get; set; }
    public int TotalPages { get; set; }
    public int TotalResults { get; set; }
}

public class Dates
{
    public string Maximum { get; set; } = string.Empty;
    public string Minimum { get; set; } = string.Empty;
}

public class Results
{
    public bool Adult { get; set; }
    public string? BackdropPath { get; set; }
    public int[]? GenreIds { get; set; }
    public int Id { get; set; }
    public string? OriginalLanguage { get; set; }
    public string? OriginalTitle { get; set; }
    public string? Overview { get; set; }
    public double? Popularity { get; set; }
    public string? PosterPath { get; set; }
    public string? ReleaseDate { get; set; }
    public string? Title { get; set; }
    public bool Video { get; set; }
    public double VoteAverage { get; set; }
    public int VoteCount { get; set; }
}

