namespace BlazorMovieDB.Models;

public interface IDetailsPage
{
    long Id { get; set; }
    bool Adult { get; set; }
    string? BackdropPath { get; set; }
    List<Genres>? Genres { get; set; }
    Uri? Homepage { get; set; }
    string? OriginalLanguage { get; set; }
    string? Overview { get; set; }
    double Popularity { get; set; }
    string? PosterPath { get; set; }
    List<ProductionCountries>? ProductionCountries { get; set; }
    List<SpokenLanguages> SpokenLanguages { get; set; }
    string? Status { get; set; }
    string? Tagline { get; set; }
    double VoteAverage { get; set; }
    long VoteCount { get; set; }
}