namespace TaskManager
{
    public class ScheduledTask
    {
        public int EmployeeId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public double RequiredHours { get; set; }

        public DateOnly DeadlineDate { get; set; }
    }
}