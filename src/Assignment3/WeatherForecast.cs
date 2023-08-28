// <copyright file="WeatherForecast.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
namespace Assignment3
{
    using System.Text.Json;

    /// <summary>
    /// WeatherForecast has date, temperature and summary as its properties.
    /// </summary>
    public class WeatherForecast
    {
        /// <summary>
        /// Gets or sets and sets Date value from user.
        /// </summary>
        /// <value>Date as string</value>
        public DateTimeOffset Date { get; set; }

        /// <summary>
        /// Gets or sets and set TemperatureCelsius value from user.
        /// </summary>
        /// <value>Tempertaure as integer</value>
        public int TemperatureCelsius { get; set; }

        /// <summary>
        /// Gets or sets and sets Summary from user.
        /// </summary>
        /// <value>Summary as string</value>
        public string? Summary { get; set; }
    }
}