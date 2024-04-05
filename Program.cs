using Azure.Identity;
using BlazorMovieDB.Components;
using BlazorMovieDB.Components.Services;

var builder = WebApplication.CreateBuilder(args);


// App configuration
builder.Configuration.AddAzureAppConfiguration(options =>
{
    options.Connect(builder.Configuration["APPCONFIG_CONNSTRING"] ?? throw new ArgumentNullException());

    options.ConfigureKeyVault(keyVaultOptions =>
    {
        keyVaultOptions.SetCredential(new DefaultAzureCredential());
    });
});

// Add services to the container.
builder.Services.AddRazorComponents().AddInteractiveServerComponents();
builder.Services.AddHttpClient();
builder.Services.AddScoped<MovieDbService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
