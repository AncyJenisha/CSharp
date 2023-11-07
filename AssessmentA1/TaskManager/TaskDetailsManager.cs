using Newtonsoft.Json;
using System.Globalization;

namespace TaskManager
{
    public class TaskDetailsManager
    {
        public List<TaskDetails> Tasks { get; set; } = new List<TaskDetails>();

        Logger Logger { get; }

        public TaskDetailsManager(Logger logger)
        {
            // InitializeDefaultTasks();
            this.Logger = logger;
        }

        public void InitializeDefaultTasks()
        {
            TaskDetails firstTask = new TaskDetails("Backend for webpage", 72D, "C#", new DateOnly(2023, 12, 21));
            TaskDetails secondTask = new TaskDetails("Automated testing software", 64D, "LabView", new DateOnly(2024, 10, 21));
            TaskDetails thirdTask = new TaskDetails("Test an application", 38D, "Testing", new DateOnly(2024, 11, 21));

            Tasks.Add(firstTask); 
            Tasks.Add(secondTask); 
            Tasks.Add(thirdTask);

            using (StreamWriter streamWriter = new StreamWriter("Tasks.json"))
            {
                string json = JsonConvert.SerializeObject(Tasks, Formatting.Indented);
                streamWriter.WriteLine(json);
            }
        }

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