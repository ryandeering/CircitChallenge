// <copyright file="Current.cs" company="RD Inc">
// Copyright (c) RD Inc. All rights reserved.
// </copyright>

namespace CircitChallenge.DataModel.Entities.CurrentWeather
{
    using System.Text.Json.Serialization;

    public class Current
    {
        [JsonPropertyName("last_updated_epoch")]
        public int LastUpdatedEpoch { get; set; }

        [JsonPropertyName("last_updated")]
        public string? LastUpdated { get; set; }

        [JsonPropertyName("temp_c")]
        public double TempCelsius { get; set; }

        [JsonPropertyName("temp_f")]
        public double TempFahrenheit { get; set; }

        [JsonPropertyName("is_day")]
        public int IsDay { get; set; }

        [JsonPropertyName("condition")]
        public Condition? Condition { get; set; }

        [JsonPropertyName("wind_mph")]
        public double WindMPH { get; set; }

        [JsonPropertyName("wind_kph")]
        public double WindKPH { get; set; }

        [JsonPropertyName("wind_degree")]
        public int WindDegree { get; set; }

        [JsonPropertyName("wind_dir")]
        public string? WindDir { get; set; }

        [JsonPropertyName("pressure_mb")]
        public double PressureMilibar { get; set; }

        [JsonPropertyName("pressure_in")]
        public double PressureIn { get; set; }

        [JsonPropertyName("precip_mm")]
        public double PrecipitationMM { get; set; }

        [JsonPropertyName("precip_in")]
        public double PrecipitationIn { get; set; }

        [JsonPropertyName("humidity")]
        public int Humidity { get; set; }

        [JsonPropertyName("cloud")]
        public int Cloud { get; set; }

        [JsonPropertyName("feelslike_c")]
        public double FeelsLikeCelsius { get; set; }

        [JsonPropertyName("feelslike_f")]
        public double FeelsLikeFahrenheit { get; set; }

        [JsonPropertyName("vis_km")]
        public double VisibilityKM { get; set; }

        [JsonPropertyName("vis_miles")]
        public double VisibilityMiles { get; set; }

        [JsonPropertyName("uv")]
        public double Ultraviolet { get; set; }

        [JsonPropertyName("gust_mph")]
        public double GustMPH { get; set; }

        [JsonPropertyName("gust_kph")]
        public double GustKPH { get; set; }
    }
}
