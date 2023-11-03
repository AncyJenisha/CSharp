// <copyright file="Employee.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Reflection
{
    /// <summary>
    /// Employee class is the base class.
    /// </summary>
    public class Employee
    {
        /// <summary>
        /// Gets or sets has the name of the employee
        /// </summary>
        /// <value>String</value>
        public string? Name { get; set; } = "Jeni";

        /// <summary>
        /// Gets or sets has the salary of the employee.
        /// </summary>
        /// <value>float number</value>
        public float Salary { get; set; } = 25000;

        /// <summary>
        /// Gets or sets the employee id.
        /// </summary>
        /// <value>Value as integer</value>
        public int EmployeeID { get; set; } = 24005;

        /// <summary>
        /// Calculates the bonous for the employee
        /// </summary>
        /// <returns>Bonus value as float</returns>
        public float CalculateBonus()
        {
            float bonus = this.Salary * 0.25F;
            return bonus;
        }

        /// <summary>
        /// Prints the details of the Employee.
        /// </summary>
        public void PrintDetails()
        {
            Console.WriteLine($"Name : {this.Name} Salary : {this.Salary} Bonus : {this.CalculateBonus()}");
        }
    }
}