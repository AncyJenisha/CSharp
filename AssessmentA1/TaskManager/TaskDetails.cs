namespace TaskManager
{
    /// <summary>
    /// TaskDetails - Has the properties of the task.
    /// </summary>
    public class TaskDetails
    {
        /// <summary>
        /// Gets or sets the description of the task as string.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the requiredhours for the task.
        /// </summary>
        public double RequiredHours { get; set; }

        /// <summary>
        /// Gets or sets the requiredskills for the task.
        /// </summary>
        public string RequiredSkills { get; set; }

        /// <summary>
        /// Gets or sets the deadline for the task.
        /// </summary>
        public DateOnly DeadlineDate { get; set; }

        /// <summary>
        /// Gets the values for the properties.
        /// </summary>
        /// <param name="description">Description of the task as string</param>
        /// <param name="requiredHours">RequiredHours for the task as double</param>
        /// <param name="requiredSkills">RequiredSkills for the task as string</param>
        /// <param name="deadlineDate">Deadline of the task as dateonly</param>
        public TaskDetails(string description, double requiredHours, string requiredSkills, DateOnly deadlineDate) 
        {
            Description = description;
            RequiredHours = requiredHours;
            RequiredSkills = requiredSkills;
            DeadlineDate = deadlineDate;
        }
    }
}