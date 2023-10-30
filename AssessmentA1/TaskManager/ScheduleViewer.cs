using ConsoleTables;
namespace TaskManager
{
    public class ScheduleViewer
    {
        public void DiplayScheduledTask()
        {
            var table = new ConsoleTable("EmployeeId", "EmployeeName", "EmployeeWorkingHours", "TaskDescription", "TaskDeadLine");
            TaskScheduler taskScheduler = new TaskScheduler();
            IEnumerable<(Employee, TaskDetails)> scheduledTask = taskScheduler.ScheduleTask();
            foreach (var employee in scheduledTask)
            {
                table.AddRow(employee.Item1.Name, employee.Item1.WorkingHours, employee.Item1.WorkingHours, employee.Item2.Description, employee.Item2.DeadlineDate);
            }
            table.Write();
        }
    }
}