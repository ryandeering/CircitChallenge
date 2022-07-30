// <copyright file="AstronomyController.cs" company="RD Inc">
// Copyright (c) RD Inc. All rights reserved.
// </copyright>

namespace CircitChallenge.API.Controllers
{
    using CircitChallenge.BLL.Interfaces;
    using CircitChallenge.DataModel.Entities.Astronomy;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class AstronomyController : ControllerBase
    {
        private readonly IBaseWeatherApiService baseWeatherApiService;

        /// <summary>
        /// Initializes a new instance of the <see cref="AstronomyController"/> class.
        /// </summary>
        /// <param name="baseWeatherApiService">Base service class wrapping HTTPClient injected into the controller.</param>
        public AstronomyController(IBaseWeatherApiService baseWeatherApiService)
        {
            this.baseWeatherApiService = baseWeatherApiService;
        }

        /// <summary>
        /// Gets astronomical data in JSON format based the city in the query.
        /// </summary>
        /// <param name="city">City for which astronomical data is requested.</param>
        /// <returns>A <see cref="Task{IActionResult}"/> representing the result of the asynchronous operation.</returns>
        [HttpGet]
        public async Task<IActionResult> GetAstronomy([FromQuery] string city)
        {
            var astronomyResponse = await this.baseWeatherApiService.GetAsync($"astronomy.json?q={city}");

            if (!astronomyResponse.IsSuccessStatusCode)
            {
                return this.BadRequest();
            }

            return this.Ok(await astronomyResponse.Content.ReadFromJsonAsync<Astronomy>());
        }
    }
}