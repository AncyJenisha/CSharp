using System.Xml.Linq;

namespace TaskManager
{
    public class TaskScheduler
    { 
        public IEnumerable<(Employee, TaskDetails)> ScheduleTask()
        {
            EmployeeManager employeeManager = new();
            TaskDetailsManager taskDetailsManager = new();
            List<Employee> listOfAvailableEmployee = new List<Employee>();

            foreach (Employee employee in employeeManager.ListOfEmployees)
            {
                if (employee.Availability == "Yes")
                {
                    listOfAvailableEmployee.Add(employee);
                }

            }

            var scheduledTask = from employee in listOfAvailableEmployee
                                join task in taskDetailsManager.ListOfTasks
                                on employee.Skills equals task.RequiredSkills
                                select (employee, task);

            Logger logger = new Logger();

            using (StreamWriter streamWriter = File.AppendText("Log.txt"))
            {
                logger.Log("TaskScheduled", streamWriter);
            }

            return scheduledTask;                    
        }

    }
}