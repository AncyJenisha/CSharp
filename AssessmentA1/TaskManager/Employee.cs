namespace TaskManager
{
    /// <summary>
    /// Has the Attributes of the employee
    /// </summary>
    public class Employee
    {
        public int EmployeeId { get; set; }

        public string EmployeeName { get; set; }

        public double WorkingHours { get; set; }

        public List<string> Skills { get; set; }

        public string Availability {  get; set; }

        public Employee(int id, string name, double workingHours, List<string> skills, string availability ) 
        {
            EmployeeId = id;
            EmployeeName = name;
            WorkingHours = workingHours;
            Skills = skills;
            Availability = availability;
        }
    }
}