namespace TaskManager
{
    /// <summary>
    /// ScheduledTask - Has the properties for the scheduled tasks.
    /// </summary>
    public class ScheduledTask
    {
        /// <summary>
        /// Gets or sets the id of the employee.
        /// </summary>
        public int EmployeeId { get; set; }

        /// <summary>
        /// Gets or sets the name of the employee.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the description of the task.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the requiredhours for the task.
        /// </summary>
        public double RequiredHours { get; set; }

        /// <summary>
        /// Gets or sets the deadline date for the task.
        /// </summary>
        public DateOnly DeadlineDate { get; set; }
    }
}