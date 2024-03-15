using BlazorMovieDB.Components.Services;
using BlazorMovieDB.Models;
using Microsoft.AspNetCore.Components;

namespace BlazorMovieDB.Components.Shared;

public partial class DetailsComponent : ComponentBase
{
    [Inject] private MovieDbService MovieDbService { get; set; } = null!;
    [Inject] private NavigationManager NavManager { get; set; } = null!;
    [Parameter] public long Id { get; set; }
    [Parameter] public string Type { get; set; } = null!;
    private MovieDetails MovieDetails { get; set; } = null!;
    private TvDetails TvDetails { get; set; } = null!;


    protected override async Task OnInitializedAsync()
    {
        if (Type.ToLower() == "movie")
        {
            MovieDetails = (await MovieDbService.GetMovieDetails(Id) ?? null)!;
        }
        else if (Type.ToLower() == "tv")
        {
            TvDetails = (await MovieDbService.GetTvDetailsAsync(Id) ?? null)!;
        }
        else
        {
            NavManager.NavigateTo("/404");
        }
    }
}