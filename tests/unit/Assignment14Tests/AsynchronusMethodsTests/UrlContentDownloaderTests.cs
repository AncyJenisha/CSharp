using AsynchronousProgramming;
using System;

namespace AsynchronusMethodsTests
{
    public class UrlContentDownloaderTests
    {
        [Theory]
        [InlineData("https://learn.microsoft.com/en-us/dotnet/api/system.diagnostics.stopwatch?view=net-7.0")]
        [InlineData("https://learn.microsoft.com/en-us/visualstudio/debugger/autos-and-locals-windows?view=vs-2022")]
        [InlineData("https://learn.microsoft.com/en-us/dotnet/standard/assembly/reference-assemblies")]
        public async Task ValidUrlGiven_DownloadFileFromUrl_ContentsFromUrlDisplayed(string url)
        {
            string expectedContentFromUrl;
            using (HttpClient client = new())
            {
                expectedContentFromUrl = await client.GetStringAsync(url);
            }

            string actualContentFromUrl = await UrlContentDownloader.DownloadFileFromUrl(url);
        
            Assert.Equal(expectedContentFromUrl, actualContentFromUrl);
        }
    }
}