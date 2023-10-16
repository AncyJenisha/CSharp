using LoggingSystem;

namespace TextLoggerTest
{
    public class CreateLoggerTest
    {
        [Fact]
        public void ValidStringGiven_CreateLogger_InstanceOfJsonLoggerTypeReturned()
        {
            SimpleLoggerFactory simpleLoggerFactory = new ();
            JsonLogger jsonLogger = new ();

            var actualInstance = simpleLoggerFactory.CreateLogger("Json");

            Assert.NotNull(actualInstance);
            Assert.Equal(actualInstance.ToString(), jsonLogger.ToString());
        }

        [Fact]
        public void ValidStringGiven_CreateLogger_InstanceOfTextLoggerTypeReturned()
        {
            SimpleLoggerFactory simpleLoggerFactory = new ();
            TextLogger textLogger = new ();

            var actualInstance = simpleLoggerFactory.CreateLogger("SimpleText");

            Assert.NotNull(actualInstance);
            Assert.Equal(actualInstance.ToString(), textLogger.ToString());
        }
    }
}