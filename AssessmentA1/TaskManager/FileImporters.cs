using Newtonsoft.Json;
using System.Reflection.PortableExecutable;
using System.Text.Json; 
namespace TaskManager
{
    public class FileImporters
    {
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