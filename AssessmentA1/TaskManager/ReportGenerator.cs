using ConsoleTables;

namespace TaskManager
{
    public class ReportGenerator
    {

        public Logger Logger { get; set; }

        public EmployeeManager EmployeeManager { get; set; }

        public TaskDetailsManager TaskDetailsManager { get; set; }

        public TaskScheduler TaskScheduler { get; set; }

        public IEnumerable<TaskDetails> UnscheduledTasks { get; set; } = new List<TaskDetails>();

        public ReportGenerator(EmployeeManager employeeManager, TaskDetailsManager taskDetailsManager, TaskScheduler taskScheduler, Logger logger)
        {
            EmployeeManager = employeeManager;
            TaskDetailsManager = taskDetailsManager;
            TaskScheduler = taskScheduler;
            Logger = logger;
        }

        public void GenerateReport()
        {
            var table = new ConsoleTable();

            if (TaskScheduler.ScheduledTasks is null)
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