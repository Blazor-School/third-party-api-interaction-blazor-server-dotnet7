using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using MultipleApiInteraction.Utilities;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddScoped<CustomHttpClient>();

builder.Services.AddHttpClient("First API", httpClient => httpClient.BaseAddress = new("http://localhost:30911"));
builder.Services.AddHttpClient("Second API", httpClient => httpClient.BaseAddress = new("http://localhost:30912"));

builder.Services.AddHttpClient<SecondApiHttpClientWrapper>(httpClient => httpClient.BaseAddress = new("http://localhost:30912"));

builder.Services.AddTransient<FirstMiddleware>();
builder.Services.AddTransient<SecondMiddleware>();
builder.Services.AddHttpClient("HttpClient with Middleware", httpClient => httpClient.BaseAddress = new("http://localhost:30912"))
       .AddHttpMessageHandler<FirstMiddleware>()
       .AddHttpMessageHandler<SecondMiddleware>();

builder.Services.AddHttpClient<InterfereByHttpClientWrapper>(httpClient => httpClient.BaseAddress = new("http://localhost:30912"));

builder.Services.AddHttpClient("InterfereWithHttpClientExtension", httpClient => httpClient.BaseAddress = new("http://localhost:30911"));

var app = builder.Build();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
