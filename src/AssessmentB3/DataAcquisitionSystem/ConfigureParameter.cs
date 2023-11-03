namespace DataAcquisitionSystem
{
    public class ConfigureParameter
    {
        public string ParameterName { get; set; }

        public double MaximumValue { get; set; }

        public double MinimumValue { get; set; }

        public ConfigureParameter( string parameter, double maximumValue, double minimumValue)
        {
            this.ParameterName = parameter;
            this.MaximumValue = maximumValue;
            this.MinimumValue = minimumValue;
        }
    }
}