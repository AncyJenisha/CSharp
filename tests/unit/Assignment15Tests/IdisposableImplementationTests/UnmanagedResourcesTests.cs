using IdisposableImplementation;

namespace IdisposableImplementationTests
{
    public class UnmanagedResourcesTests
    {
        UnmanagedResources unmanagedResources = new UnmanagedResources("Test.txt");

        [Fact]
        public void ValidStringGiven_WriteToFile_UpdatesFile()
        {
            string expectedContent = "Test Content";
            unmanagedResources.WriteToFile("Test Content");
            unmanagedResources.CloseFile();

            string fileContent = System.IO.File.ReadAllText("Test.txt");
            Assert.Contains(expectedContent, fileContent);
        }

        [Fact]
        public void WhenCalled_CloseFile_FileClosed()
        {
            unmanagedResources.WriteToFile("Test Content");
            unmanagedResources.CloseFile();

            Assert.Throws<ObjectDisposedException>(() => unmanagedResources.WriteToFile("Add Test Content"));
        }
    }
}