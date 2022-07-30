namespace CircitChallenge.IntegrationTests;

using System.Net;
using System.Text.Json;
using API.Controllers;
using BLL.Interfaces;
using DataModel.Entities.CurrentWeather;
using DataModel.Entities.Common;
using Microsoft.AspNetCore.Mvc;
using Moq;
public class CurrentWeatherTests
{
    private readonly CurrentWeatherController _controller;

    // Arrange
    private readonly Mock<IBaseWeatherApiService> _service;

    public CurrentWeatherTests()
    {
        _service = new Mock<IBaseWeatherApiService>();
        _controller = new CurrentWeatherController(_service.Object);
    }

    [Fact]
    public async Task GetCurrentWeather_ReturnsOkResult()
    {
        // Arrange
        var city = "Dublin";
        var testCurrentWeather = new CurrentWeather
        {
            Location = new Location
            {
                Name = "Dublin",
                Region = "Dublin",
                Country = "Ireland",
                Latitude = 53.33,
                Longitude = -6.25,
                TimezoneId = "Europe/Dublin",
                Epoch = 1659174732,
                Localtime = "2022-07-30 10:52"
            },

            Current = new Current
            {
                LastUpdatedEpoch = 1659174300,
                LastUpdated = "2022-07-30 10:45",
                TempCelsius = 18,
                TempFahrenheit = 64.4,
                IsDay = 1,
                Condition = new Condition {
                    Text = "Partly cloudy",
                    Icon = "//cdn.weatherapi.com/weather/64x64/day/116.png",
                    Code = 1003
                },
                WindMPH = 9.4,
                WindKPH = 15.1,
                WindDegree = 240,
                WindDir = "WSW",
                PressureMilibar = 1014,
                PressureIn = 29.94,
                PrecipitationMM = 0.1,
                PrecipitationIn = 0,
                Humidity = 88,
                Cloud = 75, 
                FeelsLikeCelsius = 18,
                FeelsLikeFahrenheit = 64.4,
                VisibilityKM = 10,
                VisibilityMiles = 6,
                Ultraviolet = 4,
                GustMPH = 10.7,
                GustKPH = 17.3
                
            }
        };

        _service.Setup(x => x.GetAsync(It.IsAny<string>())).ReturnsAsync(new HttpResponseMessage
        {
            StatusCode = HttpStatusCode.OK,
            Content = new StringContent(JsonSerializer.Serialize(testCurrentWeather))
        });

        // Act
        var result = await _controller.GetCurrentWeather(city);

        // Assert
        var okResult = Assert.IsType<OkObjectResult>(result);
        Assert.IsType<CurrentWeather>(okResult
            .Value);
        //https://docs.microsoft.com/en-us/aspnet/core/mvc/controllers/testing?view=aspnetcore-6.0
    }

    [Fact]
    public async Task GetCurrentWeather_ReturnsBadRequest()
    {
        // Arrange
        var city = "Rapture";
        _service.Setup(x => x.GetAsync(It.IsAny<string>())).ReturnsAsync(new HttpResponseMessage
        {
            StatusCode = HttpStatusCode.BadRequest
        });

        // Act
        var result = await _controller.GetCurrentWeather(city);

        // Assert
        Assert.IsType<BadRequestResult>(result);
    }


}