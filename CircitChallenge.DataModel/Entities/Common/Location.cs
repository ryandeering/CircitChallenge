// <copyright file="Location.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CircitChallenge.DataModel.Entities.Common;

using System.Text.Json.Serialization;

public class Location
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("region")]
    public string? Region { get; set; }

    [JsonPropertyName("country")]
    public string? Country { get; set; }

    [JsonPropertyName("lat")]
    public double Latitude { get; set; }

    [JsonPropertyName("lon")]
    public double Longitude { get; set; }

    [JsonPropertyName("tz_id")]
    public string? TimezoneId { get; set; }

    [JsonPropertyName("localtime_epoch")]
    public int Epoch { get; set; }

    [JsonPropertyName("localtime")]
    public string? Localtime { get; set; }
}