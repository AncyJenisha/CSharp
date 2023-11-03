namespace DataAcquisitionSystem
{
    public class ComplianceData
    {
        public string Parameter { get; set; }

        public int MaximumValue { get; set; }

        public int MinimumValue { get; set; }

        public ComplianceData(string parameter, int maximumValue, int minimumValue) 
        {
            Parameter = parameter;
            MaximumValue = maximumValue;
            MinimumValue = minimumValue;
        }
    }
}