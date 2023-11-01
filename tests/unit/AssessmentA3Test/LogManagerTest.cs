using AssessmentA3;
using Moq;
namespace AssessmentA3Test
{
    public class LogManagerTest
    {
        [Fact]
        public void WhenCalled_LogToFile_UpdatesFile()
        {
            Mock<TextWriter> mockTextWriter = new Mock<TextWriter>();
            BoilerSequenceDetails boilerSequenceDetails = new();
            boilerSequenceDetails.Time = DateTime.Now;
            boilerSequenceDetails.Event = SystemState.PrePurge;
            boilerSequenceDetails.EventData = "Pre-Purge phase completed";
            LogManager logManager = new LogManager();
            bool flag = false;
            mockTextWriter.Setup(x => x.Write(It.IsAny<string>())).Callback(() => flag = true);

            logManager.LogToFile(boilerSequenceDetails, mockTextWriter.Object);

            Assert.True(flag);
        }
    }
}