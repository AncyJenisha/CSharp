using TaskManager;
namespace TaskManagerTest
{
    public class TaskManagerTest
    {
        [Fact]
        public void ValidInputGiven_AddTaskDetails_UpdatesList()
        {
            TaskDetailsManager taskManager = new();
            TaskDetails task = new TaskDetails("Backend for webpage", 72D, "C#", new DateOnly(2023, 12, 21));
            taskManager.AddTaskDetails(task);
            Assert.Equal(4, taskManager.ListOfTasks.Count);
        }
    }

    public class TaskSchedulerTest
    {
        [Fact]
        public void WhenCalled_SceduleTask_CreatesScheduledTaskList()
        {
            TaskManager.TaskScheduler taskScheduler = new();

            IEnumerable<(Employee, TaskDetails)> scheduledTask = taskScheduler.ScheduleTask();

            Assert.Equal(2, scheduledTask.Count());

        }
    }
}