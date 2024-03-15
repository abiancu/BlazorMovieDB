using BlazorMovieDB.Components.Services;
using BlazorMovieDB.Models;
using Microsoft.AspNetCore.Components;

namespace BlazorMovieDB.Components.Shared;

public partial class CardComponent : ComponentBase
{
    [Parameter] public Movie? Movie { get; set;  }
    [Parameter] public Tv? Tv { get; set; }
    [Parameter] public string Type { get; set; } = "movie";

    protected override Task OnInitializedAsync()
    {
        return Task.CompletedTask;
    }
}