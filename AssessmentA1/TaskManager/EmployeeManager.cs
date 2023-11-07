using Newtonsoft.Json;

namespace TaskManager
{
    public class EmployeeManager
    { 
        public List<Employee> Employees { get; set; } = new List<Employee>();

        public Logger Logger { get; }

        public EmployeeManager( Logger logger) 
        {
            // InitializeDefaultEmployees();
            this.Logger = logger;
        }

        public void InitializeDefaultEmployees()
        {
            Employee firstEmployee = new Employee(24005, "Ancy Jenisha", 8D,new List<string> {"C#"}, "Yes");
            Employee secondEmployee = new Employee(24016,"Abi", 5.2D, new List<string> { "Testing" }, "Yes");
            Employees.Add(firstEmployee);
            Employees.Add(secondEmployee);
            using(StreamWriter streamWriter = new StreamWriter("Employees.json"))
            {
                string json = JsonConvert.SerializeObject(Employees, Formatting.Indented);
                streamWriter.WriteLine(json);
            }
        }

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