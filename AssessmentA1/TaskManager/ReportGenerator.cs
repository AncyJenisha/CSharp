using ConsoleTables;

namespace TaskManager
{
    /// <summary>
    /// ReportGenerator - Has methods and property to generate report.
    /// </summary>
    public class ReportGenerator
    {
        /// <summary>
        /// Gets the object logger and sets it to the instance.
        /// </summary>
        public Logger Logger { get;}

        /// <summary>
        /// Gets the object for the EmployeeManager and sets it to instance.
        /// </summary>
        public EmployeeManager EmployeeManager { get;}

        /// <summary>
        /// Gets the object for TaskDetailsManager.
        /// </summary>
        public TaskDetailsManager TaskDetailsManager { get;}

        /// <summary>
        /// Gets the object for the TaskScheduler.
        /// </summary>
        public TaskScheduler TaskScheduler { get; }

        /// <summary>
        /// Gets or sets the list of UnscheduledTasks object.
        /// </summary>
        public IEnumerable<TaskDetails> UnscheduledTasks { get; set; } = new List<TaskDetails>();

        /// <summary>
        /// Gets and assigns the objects.
        /// </summary>
        /// <param name="employeeManager">Object for the EmployeeManager class.</param>
        /// <param name="taskDetailsManager">Object for the TaskDetailsManager class.</param>
        /// <param name="taskScheduler">Object for the TaskScheduler class.</param>
        /// <param name="logger">Object for the Logger class.</param>
        public ReportGenerator(EmployeeManager employeeManager, TaskDetailsManager taskDetailsManager, TaskScheduler taskScheduler, Logger logger)
        {
            EmployeeManager = employeeManager;
            TaskDetailsManager = taskDetailsManager;
            TaskScheduler = taskScheduler;
            Logger = logger;
        }

        /// <summary>
        /// GenerateReport - generates report to print details of the unassigned tasks.
        /// </summary>
        public void GenerateReport()
        {
            var table = new ConsoleTable();

            if (TaskScheduler.ScheduledTasks.Count == 0)
            {
                Console.WriteLine("No task is scheduled\n");
            }
            else
            {
                UnscheduledTasks = from task in TaskDetailsManager.Tasks
                                   from scheduledTask in TaskScheduler.ScheduledTasks
                                   where scheduledTask.Description != task.Description
                                   select task;
                Console.WriteLine("Unscheduled Tasks\n");
                table = new ConsoleTable("TaskDetails", "DeadLine", "RequiredSkills", "RequiredHours");

                if (UnscheduledTasks.ToList().Count == 0)
                {
                    Console.WriteLine("All tasks are Scheduled\n");
                }
                else
                {
                    foreach (var task in UnscheduledTasks)
                    {

                        table.AddRow(task.Description, task.DeadlineDate, task.RequiredSkills, task.RequiredHours);
                    }

                    table.Write();
                    Logger.WriteToReportFile(UnscheduledTasks);
                }
            }


            Console.WriteLine("Upcoming DeadLines\n");
            table = new ConsoleTable("TaskDeadLine", "TaskDetails");
            foreach(var task in TaskDetailsManager.Tasks)
            {
                table.AddRow(task.DeadlineDate, task.Description);
            }
            table.Write();

            Logger.WriteDeadLineToReportFile(TaskDetailsManager.Tasks);
        }
    }
}