// <copyright file="CurrentWeatherController.cs" company="RD Inc">
// Copyright (c) RD Inc. All rights reserved.
// </copyright>

namespace CircitChallenge.API.Controllers
{
    using CircitChallenge.BLL.Interfaces;
    using CircitChallenge.DataModel.Entities.CurrentWeather;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class CurrentWeatherController : ControllerBase
    {
        private readonly IBaseWeatherApiService baseWeatherApiService;

        /// <summary>
        /// Initializes a new instance of the <see cref="CurrentWeatherController"/> class.
        /// </summary>
        /// <param name="baseWeatherApiService">Base service class wrapping HTTPClient injected into the controller.</param>
        public CurrentWeatherController(IBaseWeatherApiService baseWeatherApiService)
        {
            this.baseWeatherApiService = baseWeatherApiService;
        }

        /// <summary>
        /// Gets realtime weather data in JSON format based on the city in the query.
        /// </summary>
        /// <param name="city">City for which realtime weather data is requested.</param>
        /// <returns>A <see cref="Task{TResult}"/> representing the result of the asynchronous operation.</returns>
        [HttpGet]
        public async Task<IActionResult> GetCurrentWeather([FromQuery] string city)
        {
            var timezoneResponse = await this.baseWeatherApiService.GetAsync($"current.json?q={city}");

            if (!timezoneResponse.IsSuccessStatusCode)
            {
                return this.BadRequest();
            }

            return this.Ok(await timezoneResponse.Content.ReadFromJsonAsync<CurrentWeather>());
        }
    }
}