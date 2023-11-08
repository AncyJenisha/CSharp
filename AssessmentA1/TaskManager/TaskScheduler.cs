using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using System.Xml.Linq;

namespace TaskManager
{
    /// <summary>
    /// TaskScheduler - Has methods and properties to scahedule the task.
    /// </summary>
    public class TaskScheduler
    {
        /// <summary>
        /// Gets the logger object of the logger class.
        /// </summary>
        public Logger Logger { get; }

        /// <summary>
        /// Gets the TaskDetailsManager object of the TaskDetailsManager class.
        /// </summary>
        public TaskDetailsManager TaskDetailsManager { get; }

        /// <summary>
        /// Gets the EmployeeManager object for the EmployeeManager class.
        /// </summary>
        public EmployeeManager EmployeeManager { get; }

        /// <summary>
        /// Gets or sets the list of scheduledtask objects.
        /// </summary>
        public List<ScheduledTask> ScheduledTasks { get; set; } = new List<ScheduledTask>();

        /// <summary>
        /// Gets the object of classes.
        /// </summary>
        /// <param name="logger">object of logger class</param>
        /// <param name="taskDetailsManager">objet of TaskDetailsManager class</param>
        /// <param name="employeeManager">Object of EmployeeManager class</param>
        public TaskScheduler(Logger logger, TaskDetailsManager taskDetailsManager, EmployeeManager employeeManager)
        {
            this.Logger = logger;
            this.EmployeeManager = employeeManager;
            this.TaskDetailsManager = taskDetailsManager;
        }

        /// <summary>
        /// ScheduleTask - schedules task to employee based on conditions.
        /// </summary>
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

           /* ScheduledTasks = from scheduledTask in TaskDetailsManager.Tasks
                             from employee in listOfAvailableEmployee
                             where employee.Skills.Contains(scheduledTask.RequiredSkills)
                             select new scheduled()
                             {
                                 Name = employee.EmployeeName,
                                 EmployeeId = employee.EmployeeId,
                                 Description = scheduledTask.Description,
                                 RequiredHours = scheduledTask.RequiredHours,
                                 DeadlineDate = scheduledTask.DeadlineDate,
                             };*/

            foreach (var task in TaskDetailsManager.Tasks )
            {
                ScheduledTask scheduled = new();
                foreach (var employee in listOfAvailableEmployee)
                {
                    var numberOfDays = (task.DeadlineDate.ToDateTime(TimeOnly.Parse("10:00 PM")) - DateTime.Now).TotalDays;
                    var requiredHoursPerDay = (task.RequiredHours) / numberOfDays ;
                    if (requiredHoursPerDay <= 8 && employee.AssignedStatus == false)
                    {
                        if (requiredHoursPerDay <= employee.WorkingHours && employee.Skills.Contains(task.RequiredSkills))
                        {
                            scheduled.EmployeeId = employee.EmployeeId;
                            scheduled.RequiredHours = requiredHoursPerDay;
                            scheduled.Description = task.Description;
                            scheduled.Name = employee.EmployeeName;
                            scheduled.DeadlineDate = task.DeadlineDate;
                            ScheduledTasks.Add(scheduled);
                            employee.AssignedStatus = true;
                        }
                    }
                }
                
            }

            using (StreamWriter streamWriter = File.AppendText("Log.txt"))
            {
                Logger.Log("TaskScheduled", streamWriter);
            }

            Logger.WriteToFile(ScheduledTasks);
        }

    }
}