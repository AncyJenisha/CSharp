namespace AssessmentA3
{
    public class BoilerSequenceDetails
    {
        public string? SequenceDescription { get; set; }

        public DateTime Time { get; set; }

        public BoilerSequenceDetails(string sequenceDetails, DateTime dateTime)
        {
            SequenceDescription = sequenceDetails;
            Time = dateTime;
        }
    }
}