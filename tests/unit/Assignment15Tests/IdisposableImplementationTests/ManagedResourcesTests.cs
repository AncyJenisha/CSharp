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
            Assert.Single(managedResources.Data);
        }

        [Fact]
        public void WhenCalled_ClearData_ReducesCount()
        {
            managedResources.AddData("Test Data");
            Assert.Single(managedResources.Data);
            managedResources.ClearData();
            Assert.Empty(managedResources.Data);
        }
    }
}