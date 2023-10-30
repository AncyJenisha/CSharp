using System.Globalization;

namespace TaskManager
{
    internal class Program
    {
        static void Main()
        {
            InputValidators inputValidators = new InputValidators();
            int choiceOfOperation;
            Console.WriteLine("Welcome to task Manager");
            do
            {
                Console.WriteLine("1.Add Employee Details\n2.Add Task Details\n3.ScheduleTask\n4.Display Schedule Task\n5.Display Log\n6.Exit");
                Console.WriteLine("Enter your choice");
                choiceOfOperation = inputValidators.GetIntegerInput();
                switch (choiceOfOperation)
                {
                    case (int)MenuOptions.AddEmployeeDetails:
                        EmployeeManager employeeManager = new EmployeeManager();
                        Console.WriteLine("Enter the Employee Id:");
                        int employeeId = inputValidators.GetIntegerInput();
                        Console.WriteLine("Enter the Employee Name:");
                        string employeeName = inputValidators.GetStringInput();
                        Console.WriteLine("Enter the Working Hours Per Day:");
                        double employeeWorkingHours = inputValidators.GetDoubleInput();
                        Console.WriteLine("Enter the Employee skills");
                        string employeeSkills = inputValidators.GetStringInput();
                        Console.WriteLine("Enter the availability (Yes/No):");
                        string employeeAvailability = inputValidators.GetStringInput();
                        Employee employee = new(employeeId, employeeName, employeeWorkingHours, employeeSkills, employeeAvailability);
                        employeeManager.AddEmployeeDetails(employee);
                        break;
                    case (int)MenuOptions.AddTaskDetails:
                        TaskDetailsManager taskManager = new TaskDetailsManager();
                        Console.WriteLine("Enter the task description:");
                        string taskDescription = inputValidators.GetStringInput();
                        Console.WriteLine("Enter the Required hours");
                        double taskRequiredHours = inputValidators.GetDoubleInput();
                        Console.WriteLine("Enter the required skills:");
                        string taskRequiredWorkingSkills = inputValidators.GetStringInput();
                        Console.WriteLine("Enter the deadline in (YYYY, MM, DD) format ");
                        string date = inputValidators.GetStringInput();
                        var taskDeadline = DateOnly.Parse(date, CultureInfo.InvariantCulture);
                        TaskDetails task = new(taskDescription, taskRequiredHours, taskRequiredWorkingSkills, taskDeadline);
                        taskManager.AddTaskDetails(task);
                        break;

                    case (int)MenuOptions.ScheduleTasks:
                        TaskScheduler taskScheduler = new TaskScheduler();
                        taskScheduler.ScheduleTask();
                        break;

                    case (int)MenuOptions.DisplaySceduledTask:
                        ScheduleViewer scheduleViewer = new ScheduleViewer();
                        scheduleViewer.DiplayScheduledTask();
                        break;

                    case (int)MenuOptions.DisplayLog:
                        Logger logger = new Logger();
                        logger.DisplayLog();
                        break;

                    case (int)MenuOptions.Exit:
                        break;

                    default:
                        Console.WriteLine("Choose a valid option");
                        break;
                }
            }
            while (choiceOfOperation != 6);
            
        }
    }
}