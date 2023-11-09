using MultiLayeredAsyncOperations;
namespace MultiLayeredAsyncOperationsTests
{
    public class CpuBoundOperationsTests
    {
        [Fact]
        public async Task ValidUrlGiven_DownloadFileFromUrl_ArrayOfContentsReturned()
        {
            string expectedContentFromUrl;
            using (HttpClient client = new())
            {
                expectedContentFromUrl = await client.GetStringAsync("https://65261e7067cfb1e59ce7e912.mockapi.io/users");
            }

            string actualContentFromUrl = await CpuBoundOperations.DownloadFileFromUrl();

            Assert.Equal(expectedContentFromUrl, actualContentFromUrl);
        }

        [Fact]
        public async Task ValidUrlGiven_JsonCounterOfContentsOfUrl_ReturnsCount()
        {
            int actualCount = await CpuBoundOperations.JsonCounterOfContentsOfUrl();
            Assert.Equal(200, actualCount);
        }
    }
}