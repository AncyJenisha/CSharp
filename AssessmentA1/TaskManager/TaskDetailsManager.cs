using Newtonsoft.Json;
using System.Globalization;

namespace TaskManager
{
    /// <summary>
    /// TaskDetailsManager - Has the properties and methods for the list of tasks.
    /// </summary>
    public class TaskDetailsManager
    {
        /// <summary>
        /// Gets or sets the list of TaskDetails object
        /// </summary>
        public List<TaskDetails> Tasks { get; set; } = new List<TaskDetails>();

        /// <summary>
        /// Gets the object for the logger class.
        /// </summary>
        Logger Logger { get; }

        /// <summary>
        /// Gets and assigns the object for the logger class.
        /// </summary>
        /// <param name="logger">The object for logger class</param>
        public TaskDetailsManager(Logger logger)
        {
            // InitializeDefaultTasks();
            this.Logger = logger;
        }

        /// <summary>
        /// InitializeDefaultTasks - Adds tasks to the list of tasks.
        /// </summary>
        public void InitializeDefaultTasks()
        {
            TaskDetails firstTask = new TaskDetails("Backend for webpage", 72D, "C#", new DateOnly(2024, 05, 21));
            TaskDetails secondTask = new TaskDetails("Automated testing software", 64D, "LabView", new DateOnly(2024, 1, 21));
            TaskDetails thirdTask = new TaskDetails("Test an application", 138D, "Testing", new DateOnly(2024, 11, 21));

            Tasks.Add(firstTask); 
            Tasks.Add(secondTask); 
            Tasks.Add(thirdTask);

            using (StreamWriter streamWriter = new StreamWriter("Tasks.json"))
            {
                string json = JsonConvert.SerializeObject(Tasks, Formatting.Indented);
                streamWriter.WriteLine(json);
            }
        }

        /// <summary>
        /// AddTaskDetails -Adds the task to the task list and writes to the log file when the task is added.
        /// </summary>
        /// <param name="task">Task object</param>
        public void AddTaskDetails(TaskDetails task)
        {
            Tasks.Add(task);

            using (StreamWriter streamWriter = File.AppendText("Log.txt"))
            {
                Logger.Log("TaskDetails Added", streamWriter);
            }
        }
    }
}