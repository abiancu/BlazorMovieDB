namespace BlazorMovieDB.Models;

public interface IMediaResults
{
    long Page { get; set; }
    long TotalResults { get; set; }
    long TotalPages { get; set; }
}