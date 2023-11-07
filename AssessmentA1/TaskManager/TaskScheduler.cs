using System.Threading.Tasks;
using System.Xml.Linq;

namespace TaskManager
{
    public class TaskScheduler
    {
        public Logger Logger { get; }

        public TaskDetailsManager TaskDetailsManager { get; }

        public EmployeeManager EmployeeManager { get; }

        public IEnumerable<ScheduledTask> ScheduledTasks { get; set; }

        public TaskScheduler(Logger logger, TaskDetailsManager taskDetailsManager, EmployeeManager employeeManager)
        {
            this.Logger = logger;
            this.EmployeeManager = employeeManager;
            this.TaskDetailsManager = taskDetailsManager;
        }

        public void ScheduleTask()
        {
            EmployeeManager employeeManager = new(new Logger());
            TaskDetailsManager taskDetailsManager = new(new Logger());
            ScheduledTask scheduledTask = new();
            List<Employee> listOfAvailableEmployee = new List<Employee>();

            foreach (Employee employee in EmployeeManager.Employees)
            {
                if (employee.Availability == "Yes")
                {
                    listOfAvailableEmployee.Add(employee);
                }

            }

            ScheduledTasks = from task in TaskDetailsManager.Tasks
                             from employee in listOfAvailableEmployee
                             where employee.Skills.Contains(task.RequiredSkills) 
                             select new ScheduledTask()
                             {
                                 Name = employee.EmployeeName,
                                 EmployeeId = employee.EmployeeId,
                                 Description = task.Description,
                                 RequiredHours = task.RequiredHours,
                                 DeadlineDate = task.DeadlineDate,
                             };



            using (StreamWriter streamWriter = File.AppendText("Log.txt"))
            {
                Logger.Log("TaskScheduled", streamWriter);
            }

            Logger.WriteToFile(ScheduledTasks);
        }

    }
}