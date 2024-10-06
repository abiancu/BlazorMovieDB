using BlazorMovieDB.Models;

namespace BlazorMovieDB.Data;

public class TvDto : Tv
{
    public new long Id { get; set; }
    public new string? PosterPath { get; set; }
    public new string? Name { get; set; }
    
}