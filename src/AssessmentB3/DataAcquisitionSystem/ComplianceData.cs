namespace DataAcquisitionSystem
{
    /// <summary>
    /// ComplianceData - Has Properties for the ComplianceData.
    /// </summary>
    public class ComplianceData
    {
        /// <summary>
        /// Gets or sets the parameter as string.
        /// </summary>
        public string Parameter { get; set; }

        /// <summary>
        /// Gets or sets the maximum value as ineteger.
        /// </summary>
        public int MaximumValue { get; set; }

        /// <summary>
        /// Gets or sets the minimum value as integer.
        /// </summary>
        public int MinimumValue { get; set; }

        /// <summary>
        /// Gets and assigns the value to the properties.
        /// </summary>
        /// <param name="parameter">Parameter s string</param>
        /// <param name="maximumValue">Maximum value as integer</param>
        /// <param name="minimumValue">Minimum value as integer</param>
        public ComplianceData(string parameter, int maximumValue, int minimumValue) 
        {
            Parameter = parameter;
            MaximumValue = maximumValue;
            MinimumValue = minimumValue;
        }
    }
}