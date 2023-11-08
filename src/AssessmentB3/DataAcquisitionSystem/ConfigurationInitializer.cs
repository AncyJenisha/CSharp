using System.Text.Json;
using System.Xml.Serialization;

namespace DataAcquisitionSystem
{
    /// <summary>
    /// ConfigurationInitializer - 
    /// </summary>
    public class ConfigurationInitializer
    {
        public ConfigureData ConfigureData { get; set; }

        public InputValidators InputValidators { get; set; }

        public ConfigureParameter ConfigureParameter { get; set; }

        public ConfigurationInitializer(ConfigureData configureData, InputValidators inputValidators, ConfigureParameter configureParameter)
        {
            ConfigureData = configureData;
            InputValidators = inputValidators;
            ConfigureParameter = configureParameter;
        }

        public ConfigurationInitializer()
        {
        }

        public void SetConfiguration()
        {

            Console.WriteLine("Enter the number of paramter");
            int numberOfParameters = InputValidators.GetIntegerInput();
            for(int i = 0; i < numberOfParameters; i++)
            {
                Console.WriteLine("Enter the parameter");
                string parameter = InputValidators.GetStringInput();
                Console.WriteLine("Enter the maximum Value:");
                int maximumValue = InputValidators.GetIntegerInput();
                Console.WriteLine("Enter the minimum data:");
                int minimumValue = InputValidators.GetIntegerInput();
                ConfigureParameter = new ConfigureParameter(parameter, maximumValue, minimumValue);
                ConfigureData.Parameters.Add(ConfigureParameter);
            }

            Console.WriteLine("Enter the Rate");
            ConfigureData.Rate = InputValidators.GetIntegerInput();
            WriteConfigurationToFile(ConfigureData);
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