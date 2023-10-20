using FileProcessor;

namespace FilesAndStreamsTest
{
    public class FileModifierTests
    {
        [Fact]
        public void ValidSourceDestinationFileNamesGiven_AddCapitalizedContentToFile_FileUpdates()
        {
            using(StreamWriter streamWriter = new StreamWriter("Hello.txt"))
            {
                streamWriter.WriteLine("hello");
            }
            string destinationFileName = "Assignment17AsyncTest.txt";
            string modifiedData;

            FileModifier.AddCapitalizedContentToFile("Hello.txt", destinationFileName);

            using (StreamReader fileStream = new (destinationFileName))
            {
                modifiedData = fileStream.ReadToEnd();
            }
            Assert.Equal("HELLO\r\n", modifiedData);
        }

        [Fact]
        public async void ValidSourceAndDestinationGiven_AddCapitalizedContentToFileAsync_FileUpdated()
        {
            string destinationFile = "Assignment17.txt";
            string modifiedData;

            await FileModifier.AddCapitalizedContentToFileAsync("Hello.txt", destinationFile);

            using (StreamReader fileStream = new(destinationFile))
            {
                modifiedData = fileStream.ReadToEnd();
            }
            Assert.Equal("HELLO\r\n", modifiedData);
        }
    }
}