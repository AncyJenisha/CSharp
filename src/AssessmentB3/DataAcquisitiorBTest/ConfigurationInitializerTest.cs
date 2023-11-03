using DataAcquisitionSystem;

namespace DataAcquisitiorBTest
{
    public class ConfigurationInitializerTest
    {
        [Fact]
        public void WhenCalled_WriteConfigurationToFile_WritesToFile()
        {
            ConfigureParameter configureParameter = new ConfigureParameter("Current", 150D, 50D);
            ConfigureData configureData = new();
            configureData.rate = 1D;
            configureData.Parameters.Add(configureParameter);
            ConfigurationInitializer configurationInitializer = new ConfigurationInitializer();

            configurationInitializer.WriteConfigurationToFile(configureData);


        }
    }
}