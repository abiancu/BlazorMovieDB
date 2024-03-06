namespace BlazorMovieDB.Models;

public interface IMedia
{
    long Id { get; set; }
    bool Adult { get; set; }
    string BackdropPath { get; set; }
    List<long> GenreIds { get; set; }
    string OriginalLanguage { get; set; }
    string Overview { get; set; }
    double Popularity { get; set; }
    string PosterPath { get; set; }
    double VoteAverage { get; set; }
    
    
}