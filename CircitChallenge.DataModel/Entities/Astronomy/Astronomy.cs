// <copyright file="Astronomy.cs" company="RD Inc">
// Copyright (c) RD Inc. All rights reserved.
// </copyright>

namespace CircitChallenge.DataModel.Entities.Astronomy
{
    using System.Text.Json.Serialization;
    using CircitChallenge.DataModel.Entities.Common;

    public class Astronomy
    {
        [JsonPropertyName("location")]
        public Location? Location { get; set; }

        [JsonPropertyName("astronomy")]
        public AstronomyInner? AstronomyInner { get; set; }
    }
}