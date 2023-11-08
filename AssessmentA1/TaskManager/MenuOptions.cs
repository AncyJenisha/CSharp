namespace TaskManager
{
    /// <summary>
    /// MenuOptions - Has the options to be chosen from the console menu.
    /// </summary>
    public enum MenuOptions
    {
        /// <summary>
        /// Calls the method to add employee details to the list of the employees list.
        /// </summary>
        AddEmployeeDetails = 1,

        /// <summary>
        /// Calls the method to add task details to the list of the tasks list.
        /// </summary>
        AddTaskDetails,

        /// <summary>
        /// Calls the method to schedule task to employees.
        /// </summary>
        ScheduleTasks,

        /// <summary>
        /// Calls the method to display the scheduled task.
        /// </summary>
        DisplaySceduledTask,

        /// <summary>
        /// Calls the method to display the contents of log file.
        /// </summary>
        DisplayLog,

        /// <summary>
        /// Calls the method to generate report.
        /// </summary>
        GenerateReport,

        /// <summary>
        /// Exits the program.
        /// </summary>
        Exit,
    }
}