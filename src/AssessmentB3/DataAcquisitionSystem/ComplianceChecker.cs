namespace DataAcquisitionSystem
{
    /// <summary>
    /// ComplianceChecker - Has Properties and method to check compliance.
    /// </summary>
    public class ComplianceChecker
    {
        /// <summary>
        /// Gets or sets the object for the logger class.
        /// </summary>
        public Logger Logger { get; set; }

        /// <summary>
        /// Gets and assigns value to the properties.
        /// </summary>
        /// <param name="logger">Object of logger class</param>
        public ComplianceChecker(Logger logger)
        {
            Logger = logger;
        }

        /// <summary>
        /// CheckCompliance - Gets the list of generated data and compliance data and check if it is in the limit.
        /// </summary>
        /// <param name="generatedValue">The generated value based on the configuration limits</param>
        /// <param name="checkdata">The standard data to be comapred with.</param>
        public void CheckCompliance(List<GeneratedValue> generatedValue, List<ComplianceData> checkdata)
        {
            // To Check The compliance of the generated values.

            foreach (ComplianceData complianceData in checkdata)
            {
                foreach (GeneratedValue generated in generatedValue)
                {
                    if (complianceData.Parameter == generated.Parameter)
                    {
                        if (generated.Value < complianceData.MaximumValue && generated.Value > complianceData.MinimumValue)
                        {
                            Logger.LogWrite($"{generated.Parameter} : {generated.Value}  Compliance Successful");
                        }
                        else
                        {
                            Logger.LogWrite($"{generated.Parameter} : {generated.Value}  Compliance Failed");
                        }
                    }
                }
            }

        }
    }
}