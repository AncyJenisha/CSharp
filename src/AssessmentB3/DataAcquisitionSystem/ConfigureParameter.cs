namespace DataAcquisitionSystem
{
    public class ConfigureParameter
    {
        public string Parameter { get; set; }

        public double MaximumValue { get; set; }

        public double MinimumValue { get; set; }

        public ConfigureParameter( string parameter, double maximumValue, double minimumValue)
        {
            this.Parameter = parameter;
            this.MaximumValue = maximumValue;
            this.MinimumValue = minimumValue;
        }
    }
}