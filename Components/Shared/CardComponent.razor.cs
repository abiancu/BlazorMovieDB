using BlazorMovieDB.Data;
using Microsoft.AspNetCore.Components;

namespace BlazorMovieDB.Components.Shared;

public partial class CardComponent : ComponentBase
{
    [Parameter] public MoviesDto? Movie { get; set;  }
    [Parameter] public TvDto? Tv { get; set; }
    [Parameter] public string Type { get; set; } = "movie";

    protected override Task OnInitializedAsync()
    {
        return Task.CompletedTask;
    }
}