namespace TaskManager
{
    /// <summary>
    /// Has the Attributes of the employee
    /// </summary>
    public class Employee
    {
        /// <summary>
        /// Gets or sets the id of the employee.
        /// </summary>
        public int EmployeeId { get; set; }

        /// <summary>
        /// Gets or sets the name of the employee.
        /// </summary>
        public string EmployeeName { get; set; }

        /// <summary>
        /// Gets or sets the working hours of the employee.
        /// </summary>
        public double WorkingHours { get; set; }

        /// <summary>
        /// Gets or sets the skills of the employee as list of string.
        /// </summary>
        public List<string> Skills { get; set; }

        /// <summary>
        /// Gets or sets the availability of the employee
        /// </summary>
        public string Availability {  get; set; }

        /// <summary>
        /// Gets or sets the assigned status of the employee to the task
        /// </summary>
        public bool AssignedStatus { get; set; } = false;

        /// <summary>
        /// Sets the values to the properties of the class.
        /// </summary>
        /// <param name="id">The employee ID as integer</param>
        /// <param name="name">The name of the employee as string</param>
        /// <param name="workingHours">The working hours as double</param>
        /// <param name="skills">The skills as list of strings</param>
        /// <param name="availability">The availability as string</param>
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