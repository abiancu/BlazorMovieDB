using BlazorMovieDB.Models;
using Microsoft.AspNetCore.Components;

namespace BlazorMovieDB.Components.Pages;

public partial class MovieDetails : ComponentBase
{
    [Parameter] public long Id { get; set; }
}