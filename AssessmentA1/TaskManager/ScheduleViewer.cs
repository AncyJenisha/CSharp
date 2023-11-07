using ConsoleTables;
namespace TaskManager
{
    public class ScheduleViewer
    {
        public TaskScheduler Scheduler { get; set; }

        public ScheduleViewer(TaskScheduler taskScheduler) 
        {
            Scheduler = taskScheduler;
        }

        public void DiplayScheduledTask()
        {
            var table = new ConsoleTable("EmployeeId", "EmployeeName", "TaskDescription", "TaskDeadLine");
            if (Scheduler.ScheduledTasks is null)
            {
                Console.WriteLine("No task scheduled\n");
            }
            else
            {
                foreach (var scheduledTask in Scheduler.ScheduledTasks)
                {
                    table.AddRow(scheduledTask.EmployeeId, scheduledTask.Name, scheduledTask.Description, scheduledTask.DeadlineDate);
                }
                table.Write();
            }
        }
    }
}