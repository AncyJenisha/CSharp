using Newtonsoft.Json;
using System.Reflection.PortableExecutable;
using System.Text.Json; 
namespace TaskManager
{
    /// <summary>
    /// FileImporters - Imports the file contents.
    /// </summary>
    public class FileImporters
    {
        /// <summary>
        /// ImportEmployeeDetails - imports the employee details from the file to list of employee objects.
        /// </summary>
        /// <param name="employeeManager">object for the EmployeeManager class</param>
        public void ImportEmployeeDetails(EmployeeManager employeeManager)
        {

            // Read From File and add to list
            using (StreamReader streamReader = new StreamReader("Employees.Json"))
            {
                string? json = streamReader.ReadToEnd();
                if (json == null)
                {
                    Console.WriteLine("No employee details to import\n");
                }
                else
                {
                    employeeManager.Employees = JsonConvert.DeserializeObject<List<Employee>>(json);
                }
            }
        }

        /// <summary>
        /// ImportTaskDetails - Imports the task details from the file to list of TaskDetails object
        /// </summary>
        /// <param name="taskDetailsManager">Object for the TaskDetailsManager class</param>
        public void ImportTaskDetails(TaskDetailsManager taskDetailsManager)
        {
            // Read from File and add to taskDetails list
            using (StreamReader streamReader = new StreamReader("Tasks.Json"))
            {
                string? json = streamReader.ReadToEnd();
                if (json == null)
                {
                    Console.WriteLine("No employee details to import\n");
                }
                else
                {
                    taskDetailsManager.Tasks = JsonConvert.DeserializeObject<List<TaskDetails>>(json);
                }
            }
        }
    }
}