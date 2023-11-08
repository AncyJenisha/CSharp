using Newtonsoft.Json;

namespace TaskManager
{
    /// <summary>
    /// EmployeeManager - Has the methods and property to handle the list of employees.
    /// </summary>
    public class EmployeeManager
    { 
        /// <summary>
        /// Gets or sets the List of employees
        /// </summary>
        public List<Employee> Employees { get; set; } = new List<Employee>();

        /// <summary>
        /// Logger class instance.
        /// </summary>
        public Logger Logger { get; }

        /// <summary>
        /// Gets the object and assigns it to the instance.
        /// </summary>
        /// <param name="logger">Object logger of Logger class</param>
        public EmployeeManager( Logger logger) 
        {
            // InitializeDefaultEmployees();
            this.Logger = logger;
        }

        /// <summary>
        /// InitializeDefaultEmployees - Adds employee to the list of objects.
        /// </summary>
        public void InitializeDefaultEmployees()
        {
            Employee firstEmployee = new Employee(24005, "Ancy Jenisha", 11D,new List<string> {"C#"}, "Yes");
            Employee secondEmployee = new Employee(24016,"Abi", 10D, new List<string> { "Testing" }, "Yes");
            Employees.Add(firstEmployee);
            Employees.Add(secondEmployee);
            using(StreamWriter streamWriter = new StreamWriter("Employees.json"))
            {
                string json = JsonConvert.SerializeObject(Employees, Formatting.Indented);
                streamWriter.WriteLine(json);
            }
        }

        /// <summary>
        /// AddEmployeeDetails - Writes the employee details to the file.
        /// </summary>
        /// <param name="employee"></param>
        public void AddEmployeeDetails(Employee employee)
        {
            Employees.Add((Employee) employee);

            using (StreamWriter streamWriter = File.AppendText("Log.txt"))
            {
                Logger.Log("EmployeeAdded", streamWriter);
            }
        }
    }
}