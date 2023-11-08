using System;
using System.Data.Common;
using System.Reflection.Metadata;
using System.Text.Json;

namespace DataAcquisitionSystem
{
    public class DataAcquisitior
    {
        public ConfigureData? ConfigurationLimits { get; set; }

        public ComplianceChecker ComplianceChecker { get; set; }

        public GeneratedValue GeneratedValue { get; set; }

        public ComplianceSetter ComplianceSetter { get; set; }

        public Timer Timer { get; set; }

        public DataAcquisitior(ComplianceSetter complianceSetter, ComplianceChecker complianceChecker, GeneratedValue generatedValue, ConfigureData configureData) 
        {
            ComplianceSetter = complianceSetter;
            ComplianceChecker = complianceChecker;
            GeneratedValue = generatedValue;
            ConfigurationLimits = configureData;
        }

        public List<ConfigureParameter> ConfigureParameters { get; set; } = new ();

        public long timeperiod ;

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