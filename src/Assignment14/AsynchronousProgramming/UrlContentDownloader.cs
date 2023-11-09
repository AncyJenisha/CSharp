// <copyright file="UrlContentDownloader.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
namespace AsynchronousProgramming
{
    /// <summary>
    /// Downloads content from the given link.
    /// </summary>
    public class UrlContentDownloader
    {
        /// <summary>
        /// Displays the contents from url as string.
        /// </summary>
        /// <param name="url">The url of the website.</param>
        /// <returns>String of the contents from url.</returns>
        public static async Task<string> DownloadFileFromUrl(string url)
        {
            string contentFromUrl;
            using (HttpClient client = new ())
            {
                contentFromUrl = await client.GetStringAsync(url);
            }

            return contentFromUrl;
        }
    }
}