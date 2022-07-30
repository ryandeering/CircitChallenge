// <copyright file="AstronomyDetails.cs" company="RD Inc">
// Copyright (c) RD Inc All rights reserved.
// </copyright>

namespace CircitChallenge.DataModel.Entities.Astronomy
{
    using System.Text.Json.Serialization;

    public class AstronomyDetails
    {
        [JsonPropertyName("sunrise")]
        public string? Sunrise { get; set; }

        [JsonPropertyName("sunset")]
        public string? Sunset { get; set; }

        [JsonPropertyName("moonrise")]
        public string? Moonrise { get; set; }

        [JsonPropertyName("moonset")]
        public string? Moonset { get; set; }

        [JsonPropertyName("moon_phase")]
        public string? MoonPhase { get; set; }

        [JsonPropertyName("moon_illumination")]
        public string? MoonIllumination { get; set; }
    }
}
