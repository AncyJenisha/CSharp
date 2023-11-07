using ConsoleTables;
using System.Threading.Tasks;

namespace TaskManager
{
    public class Logger
    {
        public void Log(string logMessage, TextWriter textWriter)
        {
            textWriter.Write("\r\nLog Entry : ");
            textWriter.WriteLine($"{DateTime.Now.ToLongTimeString()} {DateTime.Now.ToLongDateString()}:{logMessage}");
        }

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

        public void WriteToFile(IEnumerable<ScheduledTask> scheduledTasks)
        {
            using (StreamWriter streamWriter = new StreamWriter("ScheduledTask.txt"))
            {
                var table = new ConsoleTable("EmployeeId", "EmployeeName", "TaskDescription", "TaskDeadLine");
                foreach (var scheduledTask in scheduledTasks)
                {
                    table.AddRow(scheduledTask.EmployeeId, scheduledTask.Name, scheduledTask.Description, scheduledTask.DeadlineDate);
                }
                streamWriter.WriteLine(table);
            }
        }

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
            }
        }

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
            }
        }
    }
}