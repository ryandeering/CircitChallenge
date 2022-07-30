// <copyright file="TimezoneController.cs" company="RD Inc">
// Copyright (c) RD Inc. All rights reserved.
// </copyright>

namespace CircitChallenge.API.Controllers;

using DataModel.Entities.Timezone;
using BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
[Produces("application/json")]
public class TimezoneController : ControllerBase
{
    private readonly IBaseWeatherApiService baseWeatherApiService;

    /// <summary>
    /// Initializes a new instance of the <see cref="TimezoneController"/> class.
    /// </summary>
    /// <param name="baseWeatherApiService">Base service class wrapping HTTPClient injected into the controller.</param>
    public TimezoneController(IBaseWeatherApiService baseWeatherApiService)
    {
        this.baseWeatherApiService = baseWeatherApiService;
    }

    /// <summary>
    /// Gets timezone data in JSON format based on the city in the query.
    /// </summary>
    /// <param name="city">City for which timezone data is requested.</param>
    /// <returns>A <see cref="Task{IActionResult}"/> representing the result of the asynchronous operation.</returns>
    [HttpGet]
    public async Task<IActionResult> GetTimezone([FromQuery] string city)
    {
        var timezoneResponse = await this.baseWeatherApiService.GetAsync($"timezone.json?q={city}");

        if (!timezoneResponse.IsSuccessStatusCode)
        {
            return this.BadRequest();
        }

        return this.Ok(await timezoneResponse.Content.ReadFromJsonAsync<Timezone>());
    }
}