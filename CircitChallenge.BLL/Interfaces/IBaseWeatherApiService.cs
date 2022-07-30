// <copyright file="IBaseWeatherApiService.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CircitChallenge.BLL.Interfaces;

public interface IBaseWeatherApiService
{
    /// <summary>
    /// Sends GET request to specified resource using HttpClient.
    /// </summary>
    /// <param name="uriParameters">Takes in an additional path on top of the base address to access the API resource specified.</param>
    /// <returns>A <see cref="Task{TResult}"/> representing the result of the asynchronous operation.</returns>
    Task<HttpResponseMessage> GetAsync(string uriParameters);
}