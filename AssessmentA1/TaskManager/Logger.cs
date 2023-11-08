using ConsoleTables;
using System.Threading.Tasks;

namespace TaskManager
{
    /// <summary>
    /// Logger - Logger class has the methods to write to file.
    /// </summary>
    public class Logger
    {
        /// <summary>
        /// Log - logs the message to the file.
        /// </summary>
        /// <param name="logMessage">The message to ne logged</param>
        /// <param name="textWriter">The textwritter object to write to file.</param>
        public void Log(string logMessage, TextWriter textWriter)
        {
            textWriter.Write("\r\nLog Entry : ");
            textWriter.WriteLine($"{DateTime.Now.ToLongTimeString()} {DateTime.Now.ToLongDateString()}:{logMessage}");
        }

        /// <summary>
        /// DisplayLog - Displays the contents of the log file.
        /// </summary>
        public void DisplayLog()
        {
            StreamReader streamReadaer = new StreamReader("Log.txt");
            string? line = streamReadaer.ReadLine();
            while (line != null)
            {
                Console.WriteLine(line);
                line = streamReadaer.ReadLine();
            }
            streamReadaer.Close();
        }

        /// <summary>
        /// WriteToFile - Writes the contents to the file.
        /// </summary>
        /// <param name="scheduledTasks">List of scheduled task</param>
        public void WriteToFile(List<ScheduledTask> scheduledTasks)
        {
            using (StreamWriter streamWriter = new StreamWriter("scheduled.txt"))
            {
                var table = new ConsoleTable("EmployeeId", "EmployeeName", "TaskDescription", "TaskDeadLine");
                foreach (var scheduledTask in scheduledTasks)
                {
                    table.AddRow(scheduledTask.EmployeeId, scheduledTask.Name, scheduledTask.Description, scheduledTask.DeadlineDate);
                }
                streamWriter.WriteLine(table);
                streamWriter.WriteLine($"\nGenerated at {DateTime.Now}\n\n");

            }
        }

        /// <summary>
        /// WriteToReportFile - writes the unscheduled task to the file.
        /// </summary>
        /// <param name="unscheduledTasks">List of tasks left unscheduled</param>
        public void WriteToReportFile(IEnumerable<TaskDetails> unscheduledTasks)
        {
            using (StreamWriter streamWriter = File.AppendText("Report.txt"))
            {
                streamWriter.WriteLine("Unscheduled Tasks\n");
                var table = new ConsoleTable("TaskDetails", "DeadLine", "RequiredSkills", "RequiredHours");
                foreach (var task in unscheduledTasks)
                {
                    table.AddRow(task.Description, task.DeadlineDate, task.RequiredSkills, task.RequiredHours);
                }
                streamWriter.WriteLine(table);
                streamWriter.WriteLine($"\nGenerated at {DateTime.Now}\n\n");
            }
        }

        /// <summary>
        /// WriteDeadLineToReportFile - writes the deadlines to the Report file.
        /// </summary>
        /// <param name="tasks">List of tasks</param>
        public void WriteDeadLineToReportFile(IEnumerable<TaskDetails> tasks)
        {
            using (StreamWriter streamWriter = File.AppendText ("Report.txt"))
            {
                streamWriter.WriteLine("The upcoming DeadLines");
                var table = new ConsoleTable("TaskDeadLine", "TaskDetails");
                foreach (var task in tasks)
                {
                    table.AddRow(task.DeadlineDate, task.Description);
                }
                streamWriter.Write(table);
                streamWriter.WriteLine($"\nGenerated at {DateTime.Now}\n\n");
            }
        }
    }
}