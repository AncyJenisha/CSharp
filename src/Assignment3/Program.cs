// <copyright file="Program.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
namespace Assignment3
{
    using System.Text.Json;

    /// <summary>
    /// Program class has the main method.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Main method has the program entry point.
        /// </summary>
        private static void Main()
        {
            var weatherForecast = new WeatherForecast
            {
                Date = DateTime.Parse("2023-08-25"),
                TemperatureCelsius = 32,
                Summary = "Warm",
            };

            string jsonString = JsonSerializer.Serialize(weatherForecast);

            Console.WriteLine(jsonString);
        }
    }
}