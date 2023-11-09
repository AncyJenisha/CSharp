namespace FilesAndStreamsTest
{
    using FileProcessor;
    public class FileWriterTests
    {
        [Fact]
        public void ValidFileNameAndSizeGiven_WriteToFile_WritesContentToFile()
        {
            string fileName = "Assignment17Test.txt";
            FileWriters.WriteToFile(fileName, 4123);
            FileInfo fileInfo = new (fileName);
            Assert.Equal(4123, fileInfo.Length);
        }

        [Fact]
        public async void ValidFileNameAndSizeGiven_WriteToFileAsync_WritesContentToFile()
        {
            string fileName = "Assignment17Test.txt";
            await FileWriters.WriteToFileAsync(fileName, 4526);

            FileInfo fileInfo = new (fileName);
            Assert.Equal(4526, fileInfo.Length);
        }
    }
}