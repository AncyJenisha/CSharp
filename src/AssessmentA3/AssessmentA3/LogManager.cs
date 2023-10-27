namespace AssessmentA3
{
    public class LogManager
    {
        public List<BoilerSequenceDetails> SequenceDetails { get; set; } = new List<BoilerSequenceDetails>();

        public List<Log> logs {  get; set; } = new List<Log>();

        public void LogToFile()
        {
        }

        public void DisplayLogs() 
        {
            foreach (var log in logs)
            {
                Console.WriteLine(log.ToString());
            }
        }

        public void DisplaySequenceDetails()
        {
            foreach (var  sequence in SequenceDetails) 
            {
                Console.WriteLine($"{sequence.SequenceDescription} : {sequence.Time}");
            }
        }
    }
}