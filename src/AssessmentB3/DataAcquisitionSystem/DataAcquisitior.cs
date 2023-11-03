using System.Text.Json;

namespace DataAcquisitionSystem
{
    public class DataAcquisitior
    {
        public void GetConfigurationLimits()
        {
            // To generate data within the configured value

            Random random = new Random();
            ConfigureData? configurationLimits = new();
            List<ConfigureParameter> configureParameters = new List<ConfigureParameter>();

            using (StreamReader streamReader = new StreamReader("ConfigurationFile.json"))
            {
                string content = streamReader.ReadToEnd();
                if (content == null)
                {
                    Console.WriteLine("File is empty");
                }
                else
                {
                    configurationLimits = JsonSerializer.Deserialize<ConfigureData>(content);
                }

            }

            if (configurationLimits != null)
            {
                double timeperiod = configurationLimits.rate;

                foreach(var parameterLimit in configurationLimits.Parameters)
                {
                    configureParameters.Add(parameterLimit);
                    double maximumNumber = parameterLimit.MaximumValue;
                    double minimumNumber = parameterLimit.MinimumValue;
                    string parameter = parameterLimit.ParameterName;
                }
            }

        }
    }
}