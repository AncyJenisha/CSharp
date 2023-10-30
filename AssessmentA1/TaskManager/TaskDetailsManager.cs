using System.Globalization;

namespace TaskManager
{
    public class TaskDetailsManager : List<TaskDetails> 
    {
        public List<TaskDetails> ListOfTasks { get; set; } = new List<TaskDetails>();

        public TaskDetailsManager()
        {
            InitializeDefaultTasks();
        }

        public void InitializeDefaultTasks()
        {
            TaskDetails firstTask = new TaskDetails("Backend for webpage", 72D, "C#", new DateOnly(2023, 12, 21));
            TaskDetails secondTask = new TaskDetails("Automated testing software", 64D, "LabView", new DateOnly(2024, 10, 21));
            TaskDetails thirdTask = new TaskDetails("Test an application", 38D, "Testing", new DateOnly(2024, 11, 21));

            ListOfTasks.Add(firstTask); 
            ListOfTasks.Add(secondTask); 
            ListOfTasks.Add(thirdTask);

        }

        public void AddTaskDetails(TaskDetails task)
        {
            
            ListOfTasks.Add(task);

            Logger logger = new Logger();

            using (StreamWriter streamWriter = File.AppendText("Log.txt"))
            {
                logger.Log("TaskDetails Added", streamWriter);
            }

        }
    }
}