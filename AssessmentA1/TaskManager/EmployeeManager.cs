namespace TaskManager
{
    public class EmployeeManager
    { 
        public List<Employee> ListOfEmployees { get; set; } = new List<Employee>();

        public EmployeeManager() 
        {
            InitializeDefaultEmployees();
        }

        public void InitializeDefaultEmployees()
        {
            Employee firstEmployee = new Employee(24005, "Ancy Jenisha", 8D, "C#", "Yes");
            Employee secondEmployee = new Employee(24016,"Abi", 5.2D, "Testing", "Yes");
            ListOfEmployees.Add(firstEmployee);
            ListOfEmployees.Add(secondEmployee);
        }

        public void AddEmployeeDetails(Employee employee)
        {
            ListOfEmployees.Add((Employee) employee);

            Logger logger = new Logger();

            using (StreamWriter streamWriter = File.AppendText("Log.txt"))
            {
                logger.Log("EmployeeAdded", streamWriter);
            }
        }
    }
}