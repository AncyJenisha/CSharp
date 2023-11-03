using System.Text.Json;
using System.Xml.Serialization;

namespace DataAcquisitionSystem
{
    public class ConfigurationInitializer
    {
        public ConfigurationInitializer()
        {
        }

        public void SetConfiguration()
        {
            ConfigureData configureData = new ConfigureData();
            InputValidators inputValidators = new InputValidators();

            Console.WriteLine("Enter the number of paramter");
            int numberOfParameters = inputValidators.GetIntegerInput();
            for(int i = 0; i < numberOfParameters; i++)
            {
                Console.WriteLine("Enter the parameter");
                string parameter = inputValidators.GetStringInput();
                Console.WriteLine("Enter the maximum value:");
                double maximumValue = inputValidators.GetDoubleInput();
                Console.WriteLine("Enter the minimum data:");
                double minimumValue = inputValidators.GetDoubleInput();
                ConfigureParameter configureParameter = new ConfigureParameter(parameter, maximumValue, minimumValue);
                configureData.Parameters.Add(configureParameter);
            }

            Console.WriteLine("Enter the rate");
            configureData.rate = inputValidators.GetDoubleInput();
            WriteConfigurationToFile(configureData);
        }

        public void WriteConfigurationToFile(ConfigureData configureData)
        {
            string jsonString = JsonSerializer.Serialize(configureData, new JsonSerializerOptions() { IncludeFields = true, WriteIndented = true });
            using (StreamWriter configureFile = new StreamWriter("ConfigurationFile.json"))
            {
                configureFile.Write(jsonString);
            }
        }
    }
}