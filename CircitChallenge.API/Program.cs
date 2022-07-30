// <copyright file="Program.cs" company="RD Inc">
// Copyright (c) RD Inc. All rights reserved.
// </copyright>

using CircitChallenge.BLL.Interfaces;
using CircitChallenge.BLL.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
IConfiguration configuration = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json")
    .Build();

builder.Services.AddControllers();

builder.Services.AddTransient<IBaseWeatherApiService, BaseWeatherApiService>();
builder.Services.AddHttpClient<IBaseWeatherApiService, BaseWeatherApiService>(c =>
{
    c.BaseAddress = new Uri("https://weatherapi-com.p.rapidapi.com/");
    c.DefaultRequestHeaders.Add("X-RapidAPI-Key", configuration["APIConfig:APIKey"]);
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

// Configure the HTTP request pipeline.
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();