namespace CircitChallenge.IntegrationTests;

using System.Net;
using System.Text.Json;
using API.Controllers;
using BLL.Interfaces;
using DataModel.Entities.Timezone;
using DataModel.Entities.Common;
using Microsoft.AspNetCore.Mvc;
using Moq;
public class TimezoneControllerTests
{
    private readonly TimezoneController _controller;

    // Arrange
    private readonly Mock<IBaseWeatherApiService> _service;

    public TimezoneControllerTests()
    {
        _service = new Mock<IBaseWeatherApiService>();
        _controller = new TimezoneController(_service.Object);
    }

    [Fact]
    public async Task GetTimezone_ReturnsOkResult()
    {
        // Arrange
        var city = "Dublin";
        var testTimezone = new Timezone
        {
            Location = new Location
            {
                Name = "Dublin",
                Region = "Dublin",
                Country = "Ireland",
                Latitude = 53.33,
                Longitude = -6.25,
                TimezoneId = "Europe/Dublin",
                Epoch = 1659002577,
                Localtime = "2022-07-28 11:02"
            }
        };

        _service.Setup(x => x.GetAsync(It.IsAny<string>())).ReturnsAsync(new HttpResponseMessage
        {
            StatusCode = HttpStatusCode.OK,
            Content = new StringContent(JsonSerializer.Serialize(testTimezone))
        });

        // Act
        var result = await _controller.GetTimezone(city);

        // Assert
        var okResult = Assert.IsType<OkObjectResult>(result);
        Assert.IsType<Timezone>(okResult
            .Value); //https://docs.microsoft.com/en-us/aspnet/core/mvc/controllers/testing?view=aspnetcore-6.0
    }

    [Fact]
    public async Task GetTimezone_ReturnsBadRequest()
    {
        // Arrange
        var city = "Rapture";
        _service.Setup(x => x.GetAsync(It.IsAny<string>())).ReturnsAsync(new HttpResponseMessage
        {
            StatusCode = HttpStatusCode.BadRequest
        });

        // Act
        var result = await _controller.GetTimezone(city);

        // Assert
        Assert.IsType<BadRequestResult>(result);
    }


}