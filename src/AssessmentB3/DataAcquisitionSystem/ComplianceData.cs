namespace DataAcquisitionSystem
{
    public class ComplianceData
    {
        public string Parameter { get; set; }

        public double MaximumValue { get; set; }

        public double MinimumValue { get; set; }

        public ComplianceData(string parameter, double maximumValue, double minimumValue) 
        {
            Parameter = parameter;
            MaximumValue = maximumValue;
            MinimumValue = minimumValue;
        }
    }
}