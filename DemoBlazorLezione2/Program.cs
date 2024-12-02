using BlazorAppCorretta.Services;
using Demo.Core.Conferenze;
using DemoBlazorLezione2.Core.Conferenze;
using DemoBlazorLezione2.Core.Northwind;
using DemoBlazorLezione2.Data;
using DemoBlazorLezione2.Data.Models;
using DemoBlazorLezione2.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddScoped<IServizioConferenze, ServizioConferenze>();
builder.Services.AddScoped<IUfficioCommerciale, UfficioCommerciale>();
builder.Services.AddScoped<IMarketing, Marketing>();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<NorthwindContext>(o =>
{
    o.UseSqlServer(connectionString);
});

builder.Services.AddScoped<ICategoryData, CategorieSQLServer>();


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
