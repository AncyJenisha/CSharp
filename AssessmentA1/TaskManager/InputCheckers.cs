using System;
using System.Globalization;

namespace TaskManager
{
    /// <summary>
    /// InputCheckers - Has methods to check the validity of the input.
    /// </summary>
    public class InputCheckers
    {
        /// <summary>
        /// Gets or sets the instance of EmployeeManager class.
        /// </summary>
        public EmployeeManager EmployeeManager { get; set; }

        /// <summary>
        /// Gets the object for the EmployeeManager class and sets it to the instance.
        /// </summary>
        /// <param name="employeeManager">Object for the employeeManager class</param>
        public InputCheckers(EmployeeManager employeeManager)
        {
            EmployeeManager = employeeManager;
        }

        /// <summary>
        /// ValidateEmployeeId - checks if the employee id is already present in the list.
        /// </summary>
        /// <param name="employeeId">Id of the employee in integer</param>
        /// <returns>Boolean value based on the condition</returns>
        public bool ValidateEmployeeId(int employeeId)
        {
            foreach(var employee in EmployeeManager.Employees)
            {
                if (employee.EmployeeId == employeeId)
                {
                    Console.WriteLine("EmployeeId Already exists\n");
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// ValidateEmployeeName - Gets the EmployeeName to validate it.
        /// </summary>
        /// <param name="employeeName">Name of the employee as string</param>
        /// <returns></returns>
        public bool ValidateEmployeeName(string employeeName)
        {
            // use regex.
            return true;
        }

        /// <summary>
        /// Gets the working hours of the employee and validates it based on condition.
        /// </summary>
        /// <param name="workingHours">The working hours as double</param>
        /// <returns>Boolean value based on the condition.</returns>
        public bool ValidateWorkingHours(double workingHours)
        {
            if(workingHours < 5 || workingHours > 12)
            {
                Console.WriteLine("Working hours must be between 5 - 12 hours");
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// ValidateTaskRequiredHours - Gets the required hours for the task and validates it based on condition.
        /// </summary>
        /// <param name="taskRequiredHours">The required hours for the task as double</param>
        /// <returns>Boolean value based on the condition</returns>
        public bool ValidateTaskRequiredHours(double taskRequiredHours)
        {
            if(taskRequiredHours < 10 || taskRequiredHours > 250)
            {
                Console.WriteLine("Check the required hours");
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// ValidateDate - Gets the date and validates it.
        /// </summary>
        /// <param name="date">date entered as string</param>
        /// <returns>Boolean value based on the condition</returns>
        public bool ValidateDate(string date)
        {
            DateOnly result = new DateOnly();
            if (!DateOnly.TryParse(date, out result))
            {
                Console.WriteLine("Enter a valid date");
                return true;
            }
            else
            {
                if (DateTime.Compare(DateTime.Now, result.ToDateTime(TimeOnly.Parse("10:00 PM"))) > 0)
                {
                    Console.WriteLine("Enter a valid date\n");
                    return true;
                }
                return false;
            }
        }

    }
}