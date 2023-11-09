using System;
using System.Data.Common;
using System.Reflection.Metadata;
using System.Text.Json;

namespace DataAcquisitionSystem
{
    /// <summary>
    /// DataAcquisitior - Has properties and methods to generate the values for the parameter
    /// </summary>
    public class DataAcquisitior
    {
        /// <summary>
        /// Gets or sets the object for ConfigurationLimits class.
        /// </summary>
        public ConfigureData? ConfigurationLimits { get; set; }

        /// <summary>
        /// Gets or sets the object for ComplianceChecker class.
        /// </summary>
        public ComplianceChecker ComplianceChecker { get; set; }

        /// <summary>
        /// Gets or sets the object for GeneratedValue class.
        /// </summary>
        public GeneratedValue GeneratedValue { get; set; }

        /// <summary>
        /// Gets and assigns the value to the properties.
        /// </summary>
        /// <param name="generatedValue">Object for the GeneratedValue class</param>
        /// <param name="configureData">Object for the configuerData class</param>
        public DataAcquisitior(GeneratedValue generatedValue, ConfigureData configureData) 
        {
            GeneratedValue = generatedValue;
            ConfigurationLimits = configureData;
        }

        /// <summary>
        /// Gets or sets the list of objects of ConfigureParameter class.
        /// </summary>
        public List<ConfigureParameter> ConfigureParameters { get; set; } = new ();

        /// <summary>
        /// Timeperiod calculated from rate
        /// </summary>
        public long timeperiod ;

        /// <summary>
        /// GetConfiguratinLimits - Gets the configuration limits to generate data.
        /// </summary>
        public void GetConfigurationLimits()
        {
            //DeserializeData from the Configure limit file

            using (StreamReader streamReader = new StreamReader("ConfigurationFile.json"))
            {
                string content = streamReader.ReadToEnd();
                if (content == null)
                {
                    Console.WriteLine("File is empty");
                }
                else
                {
                    ConfigurationLimits = JsonSerializer.Deserialize<ConfigureData>(content);
                }
            }

            if (ConfigurationLimits != null)
            {
                timeperiod = ConfigurationLimits.Rate * 1000;

                foreach (var parameterLimit in ConfigurationLimits.Parameters)
                {
                    ConfigureParameters.Add(parameterLimit);
                }
            }
        }
    }
}