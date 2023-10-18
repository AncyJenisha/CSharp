using LoggingSystemForMultipleUsers;

namespace TestProject1
{
    public class LoggerTest
    {
        [Fact]
        public void ValidMessageGiven_LoggError_LogsMessage()
        {
            string filename = "Log.txt";
            string message = "Logged message";

            Logger.LogError(filename, message);

            string actualMessage;
            using(StreamReader streamReader = new(filename))
            {
                actualMessage = streamReader.ReadToEnd();
            }
            Assert.Equal(message, actualMessage);
        }
    }
}