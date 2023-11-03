namespace DataAcquisitionSystem
{
    public class ConfigureParameter
    {
        public ConfigureParameter() { }

        public string ParameterName { get; set; }

        public int MaximumValue { get; set; }

        public int MinimumValue { get; set; }

        public ConfigureParameter( string parameter, int maximumValue, int minimumValue)
        {
            this.ParameterName = parameter;
            this.MaximumValue = maximumValue;
            this.MinimumValue = minimumValue;
        }
    }
}