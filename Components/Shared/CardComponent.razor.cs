using BlazorMovieDB.Models;
using Microsoft.AspNetCore.Components;

namespace BlazorMovieDB.Components.Shared;

public partial class CardComponent : ComponentBase
{
    [Parameter] public Movie? Movie { get; set;  }

    protected override Task OnInitializedAsync()
    {
       return Task.CompletedTask;
    }
}