using TaskManager;
namespace TaskManagerTest
{
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