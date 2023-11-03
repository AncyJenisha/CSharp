using System;
using System.Data.Common;
using System.Reflection.Metadata;
using System.Text.Json;

namespace DataAcquisitionSystem
{
    public class DataAcquisitior
    {
       public List<ConfigureParameter> ConfigureParameters { get; set; } = new ();

        public void GetConfigurationLimits()
        {
            //DeserializeData from the Configure limit file

            ConfigureData? configurationLimits = new ConfigureData();

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
                long timeperiod = configurationLimits.Rate * 1000;
                Timer timer = new Timer();
                timer.SetTimer(timeperiod);

                foreach (var parameterLimit in configurationLimits.Parameters)
                {
                    ConfigureParameters.Add(parameterLimit);
                }
            }

        }

        public void GenerateData()
        {
            // To generate data within the configured Value

            GeneratedValue generatedValue = new GeneratedValue();
            ComplianceSetter complianceSetter = new();
            ComplianceChecker complianceChecker = new ComplianceChecker();
            Random random = new Random();
            foreach (var parameterLimit in ConfigureParameters)
            {
                generatedValue.Parameter = parameterLimit.ParameterName;
                generatedValue.Value = random.Next(parameterLimit.MinimumValue, parameterLimit.MaximumValue);
                complianceChecker.CheckCompliance(generatedValue, complianceSetter.ComplianceDataOfAllParameters);
            }
            
        }
    }
}