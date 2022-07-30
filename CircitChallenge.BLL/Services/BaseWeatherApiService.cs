// <copyright file="BaseWeatherApiService.cs" company="RD Inc">
// Copyright (c) RD Inc. All rights reserved.
// </copyright>

namespace CircitChallenge.BLL.Services;

using Interfaces;
using Microsoft.AspNetCore.Mvc;

// typed pattern slightly inspired by https://www.rahulpnath.com/blog/are-you-using-httpclient-in-the-right-way/
public class BaseWeatherApiService : IBaseWeatherApiService
{
    private readonly HttpClient httpClient;

    /// <summary>
    /// Initializes a new instance of the <see cref="BaseWeatherApiService"/> class.
    /// </summary>
    /// <param name="httpClient">HttpClient to be injected into service, configured in Program.cs.</param>
    public BaseWeatherApiService(HttpClient httpClient)
    {
        this.httpClient = httpClient;
    }

    /// <inheritdoc/>
    [HttpGet]
    public async Task<HttpResponseMessage> GetAsync(string uriParameters)
    {
        var response = await this.httpClient.GetAsync(uriParameters);
        return response;
    }
}