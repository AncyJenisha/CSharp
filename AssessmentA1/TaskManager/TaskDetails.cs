namespace TaskManager
{
    public class TaskDetails
    {
        public string Description { get; set; }

        public double RequiredHours { get; set; }

        public string RequiredSkills { get; set; }

        public DateOnly DeadlineDate { get; set; }

        public TaskDetails(string description, double requiredHours, string requiredSkills, DateOnly deadlineDate) 
        {
            Description = description;
            RequiredHours = requiredHours;
            RequiredSkills = requiredSkills;
            DeadlineDate = deadlineDate;
        }
    }
}