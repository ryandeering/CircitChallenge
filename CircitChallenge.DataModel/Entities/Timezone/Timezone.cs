// <copyright file="Timezone.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CircitChallenge.DataModel.Entities.Timezone;

using System.Text.Json.Serialization;
using CircitChallenge.DataModel.Entities.Common;

public class Timezone
{
    [JsonPropertyName("location")]
    public Location? Location { get; set; }
}