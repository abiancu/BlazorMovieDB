using BlazorMovieDB.Components.Services;
using BlazorMovieDB.Models;
using Microsoft.AspNetCore.Components;

namespace BlazorMovieDB.Components.Pages;

public partial class TvDetailsPage : ComponentBase
{
    [Inject] public MovieDbService? MovieDbService { get; set; }
    [Parameter] public long Id { get; set; }
    private TvDetails? Details { get; set; }

    protected override async Task OnInitializedAsync()
    {
       await GetTvDetails(Id);
    }

    private async Task GetTvDetails(long id)
    {
        if (MovieDbService is not null) Details = await MovieDbService.GetTvDetailsAsync(id);
    }
}