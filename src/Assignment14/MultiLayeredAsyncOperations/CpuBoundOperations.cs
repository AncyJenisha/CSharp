// <copyright file="CpuBoundOperations.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
using System;
using Newtonsoft;
using Newtonsoft.Json.Linq;

namespace MultiLayeredAsyncOperations
{
    /// <summary>
    /// CPU
    /// </summary>
    public class CpuBoundOperations
    {
        /// <summary>
        /// Gives a list of urls.
        /// </summary>
        /// <returns>List of urls as strings</returns>
        public static async Task<string> UrlGenerator()
        {
            List<string> listOfUrl = new ()
            {
                "https://65261e7067cfb1e59ce7e912.mockapi.io/users",
                "https://65261e7067cfb1e59ce7e912.mockapi.io/articals",
            };
            await Task.Delay(10000);
            return listOfUrl[0];
        }

        /// <summary>
        /// Downloads contents from url.
        /// </summary>
        /// <returns>String of content from url</returns>
        public static async Task<string> DownloadFileFromUrl()
        {
            string url = await UrlGenerator();
            string contentFromUrl;
            HttpClient client = new ();
            contentFromUrl = await client.GetStringAsync(url);
            return contentFromUrl;
        }

        /// <summary>
        /// Counts the JSON objects
        /// </summary>
        /// <returns>Count as integer</returns>
        public static async Task<int> JsonCounterOfContentsOfUrl()
        {
            int count = 0;
            string content = await DownloadFileFromUrl();
            JArray jArray = JArray.Parse(content);
            foreach (var jObject in jArray)
            {
                count += jObject.Count();
            }

            Console.WriteLine("\nParsed Response");
            Console.WriteLine(jArray);

            return count;
        }
    }
}