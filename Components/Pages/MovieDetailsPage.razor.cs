using BlazorMovieDB.Components.Services;
using BlazorMovieDB.Models;
using Microsoft.AspNetCore.Components;

namespace BlazorMovieDB.Components.Pages;

public partial class MovieDetailsPage : ComponentBase
{
    [Inject] public MovieDbService? MovieDbService { get; set; }
    [Parameter] public long Id { get; set; }
    private MovieDetails? Details { get; set; }

    protected override async Task OnInitializedAsync()
    {
         await GetDetails(Id);
    }
    private async Task GetDetails(long id)
    {
        if (MovieDbService is not null) Details = await MovieDbService.GetMovieDetails(id);
    }
}
