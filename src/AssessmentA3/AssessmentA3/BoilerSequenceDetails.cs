namespace AssessmentA3
{
    /// <summary>
    /// BoilerSequenceDetails - Has the details of the state of the boiler.
    /// </summary>
    public class BoilerSequenceDetails
    {
        public string EventData { get; set; } = "";

        public SystemState Event { get; set; } = SystemState.LockOut;

        public DateTime Time { get; set; }
    }
}