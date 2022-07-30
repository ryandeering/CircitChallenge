namespace CircitChallenge.IntegrationTests;

using System.Net;
using System.Text.Json;
using API.Controllers;
using BLL.Interfaces;
using DataModel.Entities.Astronomy;
using DataModel.Entities.Common;
using Microsoft.AspNetCore.Mvc;
using Moq;
public class AstronomyControllerTests
{
    private readonly AstronomyController _controller;

    // Arrange
    private readonly Mock<IBaseWeatherApiService> _service;

    public AstronomyControllerTests()
    {
        _service = new Mock<IBaseWeatherApiService>();
        _controller = new AstronomyController(_service.Object);
    }

    [Fact]
    public async Task GetAstronomy_ReturnsOkResult()
    {
        // Arrange
        var city = "Dublin";
        var testAstronomy = new Astronomy
        {
            Location = new Location
            {
                Name = "Dublin",
                Region = "Dublin",
                Country = "Ireland",
                Latitude = 53.33,
                Longitude = -6.25,
                TimezoneId = "Europe/Dublin",
                Epoch = 1659178563,
                Localtime = "2022-07-30 11:56"
            },

            AstronomyInner = new AstronomyInner{
                AstronomyDetails = new AstronomyDetails {
                    Sunrise = "05:38AM",
                    Sunset = "09:24PM",
                    Moonrise = "07:01AM",
                    Moonset = "10:39PM",
                    MoonPhase = "New Moon",
                    MoonIllumination = "12"
                }
            }
        };

        _service.Setup(x => x.GetAsync(It.IsAny<string>())).ReturnsAsync(new HttpResponseMessage
        {
            StatusCode = HttpStatusCode.OK,
            Content = new StringContent(JsonSerializer.Serialize(testAstronomy))
        });

        // Act
        var result = await _controller.GetAstronomy(city);

        // Assert
        var okResult = Assert.IsType<OkObjectResult>(result);
        Assert.IsType<Astronomy>(okResult.Value);
        //Assert.Equal<Astronomy>(testAstronomy, (Astronomy)okResult.Value); 
        //https://docs.microsoft.com/en-us/aspnet/core/mvc/controllers/testing?view=aspnetcore-6.0
    }

    [Fact]
    public async Task GetAstronomy_ReturnsBadRequest()
    {
        // Arrange
        var city = "Rapture";
        _service.Setup(x => x.GetAsync(It.IsAny<string>())).ReturnsAsync(new HttpResponseMessage
        {
            StatusCode = HttpStatusCode.BadRequest
        });

        // Act
        var result = await _controller.GetAstronomy(city);

        // Assert
        Assert.IsType<BadRequestResult>(result);
    }


}