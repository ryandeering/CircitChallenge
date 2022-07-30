namespace CircitChallenge.UnitTests;

using System.Net;
using BLL.Interfaces;
using BLL.Services;

public class BaseWeatherApiServiceTests
{
    private readonly IBaseWeatherApiService _baseWeatherApiService;
    private readonly HttpClient _httpClient;

    public BaseWeatherApiServiceTests()
    {
        _httpClient = new HttpClient();
        _baseWeatherApiService = new BaseWeatherApiService(_httpClient);
    }

    [Fact]
    public async Task When_GetAsync_Is_Called_Returns_OkStatus()
    {
        //Arrange
        var validUri = "https://httpstat.us/200";

        //Act
        var response = await _baseWeatherApiService.GetAsync(validUri);

        //Assert
        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
    }

    [Fact]
    public async Task When_GetAsync_Is_Called_Returns_NotFoundStatus()
    {
        //Arrange
        var validUri = "https://httpstat.us/404";

        //Act
        var response = await _baseWeatherApiService.GetAsync(validUri);

        //Assert
        Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);
    }
}