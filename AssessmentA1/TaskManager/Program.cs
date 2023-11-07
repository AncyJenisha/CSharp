using System.Globalization;

namespace TaskManager
{
    internal class Program
    {
        static void Main()
        {
            InputValidators inputValidators = new InputValidators();
            FileImporters fileImporters = new FileImporters();
            int choiceOfOperation;
            string? employeeSkill;
            List<string> employeeSkills = new List<string>();
            Logger logger = new Logger();
            EmployeeManager employeeManager = new EmployeeManager(logger);
            TaskDetailsManager taskManager = new TaskDetailsManager(logger);
            TaskScheduler taskScheduler = new TaskScheduler(logger, taskManager, employeeManager);
            ScheduleViewer scheduleViewer = new ScheduleViewer(taskScheduler);
            ReportGenerator reportGenerator = new ReportGenerator(employeeManager, taskManager, taskScheduler, logger);

            fileImporters.ImportEmployeeDetails(employeeManager);
            fileImporters.ImportTaskDetails(taskManager);

            Console.WriteLine("Welcome to task Manager");
   
            do
            {
                Console.WriteLine("1.Add Employee Details\n2.Add Task Details\n3.ScheduleTask\n4.Display Schedule Task\n5.Display Log\n6.Generate Report\n7.Exit");
                Console.WriteLine("Enter your choice");
                choiceOfOperation = inputValidators.GetIntegerInput();
                switch (choiceOfOperation)
                {
                    case (int)MenuOptions.AddEmployeeDetails:
                        Console.WriteLine("Enter the Employee EmployeeId:");
                        int employeeId = inputValidators.GetIntegerInput();
                        Console.WriteLine("Enter the Employee EmployeeName:");
                        string employeeName = inputValidators.GetStringInput();
                        Console.WriteLine("Enter the Working Hours Per Day:");
                        double employeeWorkingHours = inputValidators.GetDoubleInput();
                        Console.WriteLine("Enter the Employee skills");
                        employeeSkill = inputValidators.GetStringInput();
                        while (employeeSkill != "")
                        {
                            employeeSkill = Console.ReadLine();
                            if (employeeSkill != " ")
                            {
                                employeeSkills.Add(employeeSkill);
                            }
                        }
                        Console.WriteLine("Enter the availability (Yes/No):");
                        string employeeAvailability = inputValidators.GetStringInput();
                        Employee employee = new(employeeId, employeeName, employeeWorkingHours, employeeSkills, employeeAvailability);
                        employeeManager.AddEmployeeDetails(employee);
                        break;

                    case (int)MenuOptions.AddTaskDetails:
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
                        taskScheduler.ScheduleTask();
                        break;

                    case (int)MenuOptions.DisplaySceduledTask:
                        scheduleViewer.DiplayScheduledTask();
                        break;

                    case (int)MenuOptions.DisplayLog:
                        logger.DisplayLog();
                        break;
                    case (int)MenuOptions.GenerateReport:
                        reportGenerator.GenerateReport();
                        break;
                    case (int)MenuOptions.Exit:
                        break;

                    default:
                        Console.WriteLine("Choose a valid option");
                        break;
                }
            }
            while (choiceOfOperation != 7);
            
        }
    }
}