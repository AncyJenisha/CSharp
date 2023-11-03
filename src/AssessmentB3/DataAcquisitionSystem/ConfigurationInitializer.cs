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

            Console.WriteLine("Enter the parameter");
            string parameter = inputValidators.GetStringInput();
            Console.WriteLine("Enter the maximum value:");
            double maximumValue = inputValidators.GetDoubleInput();
            Console.WriteLine("Eneter the minimum data:");
            double minimumValue = inputValidators.GetDoubleInput();
            ConfigureParameter configureParameter = new ConfigureParameter(parameter, maximumValue, minimumValue);

            Console.WriteLine("Enter the rate");
            configureData.rate = inputValidators.GetDoubleInput();
            configureData.Parameters.Add(configureParameter);
            WriteConfigurationToFile(configureData);
        }

        public void WriteConfigurationToFile( ConfigureData configureData)
        {
            string jsonString = JsonSerializer.Serialize(configureData, new JsonSerializerOptions() { IncludeFields = true ,WriteIndented = true});
            using (StreamWriter configureFile = new StreamWriter("ConfigurationFile.json"))
            {
                configureFile.Write(jsonString);
            }
        }
    }
}