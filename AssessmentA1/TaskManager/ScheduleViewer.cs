using ConsoleTables;
namespace TaskManager
{
    /// <summary>
    /// ScheduleViewer - Has methods and properties to display the scheduled tasks.
    /// </summary>
    public class ScheduleViewer
    {
        /// <summary>
        /// Gets the object for the class TaskScheduler.
        /// </summary>
        public TaskScheduler Scheduler { get;}

        /// <summary>
        /// Gets and assigns object for the TaskScheduler class.
        /// </summary>
        /// <param name="taskScheduler"></param>
        public ScheduleViewer(TaskScheduler taskScheduler) 
        {
            Scheduler = taskScheduler;
        }

        /// <summary>
        /// DisplayScheduledTask - Displays the list of scheduled task.
        /// </summary>
        public void DiplayScheduledTask()
        {
            if (Scheduler.ScheduledTasks.Count == 0)
            {
                Console.WriteLine("No task scheduled\n");
            }
            else
            {
                var table = new ConsoleTable("EmployeeId", "EmployeeName", "TaskDescription", "TaskDeadLine");
                foreach (var scheduledTask in Scheduler.ScheduledTasks)
                {
                    table.AddRow(scheduledTask.EmployeeId, scheduledTask.Name, scheduledTask.Description, scheduledTask.DeadlineDate);
                }
                table.Write();
            }
        }
    }
}