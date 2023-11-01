namespace AssessmentA3
{
    using ConsoleTables;

    /// <summary>
    /// LogManager - Has methods to read and write log file.
    /// </summary>
    public class LogManager
    {
        /// <summary>
        /// Logs to the file.
        /// </summary>
        /// <param name="sequenceData">The details of the state of the boiler</param>
        /// <param name="textWriter">TextWriter object</param>
        public void LogToFile(BoilerSequenceDetails sequenceData, TextWriter textWriter)
        {
            textWriter.Write("Log Entry : ");
            textWriter.WriteLine($"{sequenceData.Event},  {sequenceData.Time},  {sequenceData.EventData}");
        }

        /// <summary>
        /// Displays the contents of log file.
        /// </summary>
        public void DisplayLogs()
        {
            var table = new ConsoleTable("Event", "Time", "EventData");
            using (StreamReader streamReader = new StreamReader("Log.txt"))
            {
                string? fileContent = streamReader.ReadToEnd();
                Console.WriteLine(fileContent);
            }
        }
    }
}