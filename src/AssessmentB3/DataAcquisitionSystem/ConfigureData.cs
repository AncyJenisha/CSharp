using System.Numerics;

namespace DataAcquisitionSystem
{
    /// <summary>
    /// ConfigureData - Has properties for the configuration data
    /// </summary>
    public class ConfigureData
    {
        /// <summary>
        /// The rate of data generation.
        /// </summary>
        public int Rate { get; set; } 

        /// <summary>
        /// Gets or sets the parameter as list of configure parameter.
        /// </summary>
        public List<ConfigureParameter> Parameters { get; set; } = new List<ConfigureParameter>();

    }
}