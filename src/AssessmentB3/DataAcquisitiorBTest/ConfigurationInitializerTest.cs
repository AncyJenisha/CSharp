using DataAcquisitionSystem;

namespace DataAcquisitiorBTest
{
    public class ConfigurationInitializerTest
    {
        [Fact]
        public void WhenCalled_WriteConfigurationToFile_WritesToFile()
        {
            ConfigureParameter configureParameter = new ConfigureParameter("Current", 150, 50);
            ConfigureData configureData = new();
            configureData.Rate = 1;
            configureData.Parameters.Add(configureParameter);
            ConfigurationInitializer configurationInitializer = new ConfigurationInitializer();

            configurationInitializer.WriteConfigurationToFile(configureData);
        }
    }
}