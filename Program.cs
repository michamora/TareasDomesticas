using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using TareasDomesticas.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Net.Http;
using Blazored.Toast;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();

builder.Services.AddBlazoredToast();




builder.Services.AddScoped<HttpClient>(_ =>
{
    var sp = new HttpClient
    {
        BaseAddress = new Uri("http://gestordomestico.somee.com/")
    };
    return sp;
}
);

var ConStr = builder.Configuration.GetConnectionString("ConStr");
builder.Services.AddDbContext<Contexto>(options =>
    options.UseSqlite(ConStr));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
