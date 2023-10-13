using IdisposableImplementation;
namespace IdisposableImplementationTests
{
    public class ManagedResourcesTests
    {
        ManagedResources managedResources =new ManagedResources();

        [Fact]
        public void ValidDataGiven_AddData_UpdatesList()
        {
            managedResources.AddData("Test Data");
            Assert.Single(managedResources.ListOfData);
        }

        [Fact]
        public void WhenCalled_ClearData_ReducesCount()
        {
            managedResources.AddData("Test Data");
            Assert.Single(managedResources.ListOfData);
            managedResources.ClearData();
            Assert.Empty(managedResources.ListOfData);
        }
    }
}