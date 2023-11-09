namespace DataAcquisitionSystem
{
    /// <summary>
    /// ConfigureParameter - Has properties for the configuration data.
    /// </summary>
    public class ConfigureParameter
    {

        public ConfigureParameter() { }

        /// <summary>
        /// Gets or sets the name of the parameter to be generated.
        /// </summary>
        public string ParameterName { get; set; }

        /// <summary>
        /// Gets or sets the maximum value of the parameter
        /// </summary>
        public int MaximumValue { get; set; }

        /// <summary>
        /// Gets or sets the minimum value of the parameter.
        /// </summary>
        public int MinimumValue { get; set; }

        /// <summary>
        /// Gets and assigns value to the properties.
        /// </summary>
        /// <param name="parameter">The parameter name as string</param>
        /// <param name="maximumValue">The maximum value as integer</param>
        /// <param name="minimumValue">The minimum value as integer</param>
        public ConfigureParameter( string parameter, int maximumValue, int minimumValue)
        {
            this.ParameterName = parameter;
            this.MaximumValue = maximumValue;
            this.MinimumValue = minimumValue;
        }
    }
}