using FileProcessor;

namespace FilesAndStreamsTest
{
    public class FileModifierTests
    {
        [Fact]
        public void ValidSourceDestinationFileNamesGiven_AddCapitalizedContentToFile_FileUpdates()
        {
            string sourceFileName = "Hello.txt";
            string destinationFileName = "Assignment17AsyncTest.txt";
            string modifiedData;

            FileModifier.AddCapitalizedContentToFile(sourceFileName, destinationFileName);

            using (StreamReader fileStream = new (destinationFileName))
            {
                modifiedData = fileStream.ReadToEnd();
            }
            Assert.Equal("HELLO", modifiedData);
        }

        [Fact]
        public async void ValidSourceAndDestinationGiven_AddCapitalizedContentToFileAsync_FileUpdated()
        {
            string sourceFile = "Hello.txt";
            string destinationFile = "Assignment17.txt";
            string modifiedData;

            await FileModifier.AddCapitalizedContentToFileAsync(sourceFile, destinationFile);

            using (StreamReader fileStream = new(destinationFile))
            {
                modifiedData = fileStream.ReadToEnd();
            }
            Assert.Equal("HELLO", modifiedData);
        }
    }
}