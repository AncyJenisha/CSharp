namespace AssessmentA3
{
    public class LogManager
    {

        public void LogToFile(BoilerSequenceDetails sequenceData, TextWriter w)
        {
            w.Write("Log Entry : ");
            w.WriteLine($"{sequenceData.Event},  {sequenceData.Time},  {sequenceData.EventData}");
        }

        public void DisplayLogs()
        {
            using (StreamReader streamReader = new StreamReader("Log.txt"))
            {
                string? line = streamReader.ReadToEnd();
                Console.WriteLine(line);
            }
        }
    }
}