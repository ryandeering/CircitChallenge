// <copyright file="AstronomyInner.cs" company="RD Inc">
// Copyright (c) RD Inc. All rights reserved.
// </copyright>

namespace CircitChallenge.DataModel.Entities.Astronomy
{
    using System.Text.Json.Serialization;

    public class AstronomyInner
    {
        [JsonPropertyName("astro")]
        public AstronomyDetails? AstronomyDetails { get; set; }
    }
}
