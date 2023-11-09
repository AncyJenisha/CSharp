using System.Text.Json;
using System.Xml.Serialization;

namespace DataAcquisitionSystem
{
    /// <summary>
    /// ConfigurationInitializer - Has methods to set the configuration limits and its properties.
    /// </summary>
    public class ConfigurationInitializer
    {
        /// <summary>
        /// Gets or sets the object for the ConfigureData class.
        /// </summary>
        public ConfigureData ConfigureData { get; set; }

        /// <summary>
        /// Gets or sets the object for the InputValidator class.
        /// </summary>
        public InputValidators InputValidators { get; set; }

        /// <summary>
        /// Gets or sets the object for ConfigureParameter class.
        /// </summary>
        public ConfigureParameter ConfigureParameter { get; set; }

        /// <summary>
        /// Gets and assigns the value for the properties.
        /// </summary>
        /// <param name="configureData">Object for the ConfigureData class.</param>
        /// <param name="inputValidators">Object for InputValidator class</param>
        /// <param name="configureParameter">Object for Configureparameter class</param>
        public ConfigurationInitializer(ConfigureData configureData, InputValidators inputValidators, ConfigureParameter configureParameter)
        {
            ConfigureData = configureData;
            InputValidators = inputValidators;
            ConfigureParameter = configureParameter;
        }

        public ConfigurationInitializer()
        {
        }

        /// <summary>
        /// SetConfiguration - Sets the configuration value.
        /// </summary>
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

        /// <summary>
        /// WriteConfigurationToFile - Writes the set configuration value to the file.
        /// </summary>
        /// <param name="configureData">The ConfigureData set by the user.</param>
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