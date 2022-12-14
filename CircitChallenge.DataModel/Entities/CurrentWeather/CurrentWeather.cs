// <copyright file="CurrentWeather.cs" company="RD Inc">
// Copyright (c) RD Inc. All rights reserved.
// </copyright>

namespace CircitChallenge.DataModel.Entities.CurrentWeather
{
    using System.Text.Json.Serialization;
    using CircitChallenge.DataModel.Entities.Common;

    public class CurrentWeather
    {
        [JsonPropertyName("location")]
        public Location? Location { get; set; }

        [JsonPropertyName("current")]
        public Current? Current { get; set; }
    }
}
