// <copyright file="Program.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace AsynchronousProgramming
{
    /// <summary>
    /// Program class has the main method
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Main method gets the url and calls the function.
        /// </summary>
        private static async Task Main()
        {
            var contentFromFirstUrl = await UrlContentDownloader.DownloadFileFromUrl("https://www.poetryfoundation.org/poems/42891/stopping-by-woods-on-a-snowy-evening");
            Console.WriteLine(contentFromFirstUrl);
            var contentFromSecondUrl = await UrlContentDownloader.DownloadFileFromUrl("https://www.poetryfoundation.org/poems/44272/the-road-not-taken");
            Console.WriteLine(contentFromSecondUrl);
        }
    }
}