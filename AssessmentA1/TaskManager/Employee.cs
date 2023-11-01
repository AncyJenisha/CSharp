namespace TaskManager
{
    /// <summary>
    /// Has the Attributes of the employee
    /// </summary>
    public class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public double WorkingHours { get; set; }

        public IEnumerable<string> Skills { get; set; }

        public string Availability {  get; set; }

        public Employee(int id, string name, double workingHours, IEnumerable<string> skills, string availability ) 
        {
            Id = id;
            Name = name;
            WorkingHours = workingHours;
            Skills = skills;
            Availability = availability;
        }
    }
}