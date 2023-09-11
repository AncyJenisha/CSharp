// <copyright file="Employee.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace EmployeeHierarchy
{
    /// <summary>
    /// Employee class is the base class.
    /// </summary>
    public abstract class Employee
    {
        /// <summary>
        /// Gets or sets has the name of the employee
        /// </summary>
        /// <value>String</value>
        public string? Name { get; set; }

        /// <summary>
        /// Gets or sets has the salary of the employee.
        /// </summary>
        /// <value>float number</value>
        public float Salary { get; set; }

        /// <summary>
        /// Calculates the bonous for the employee
        /// </summary>
        /// <returns>Bonus value as float</returns>
        public abstract float CalculateBonus();

        /// <summary>
        /// Prints the details of the Employee.
        /// </summary>
        public abstract void PrintDetails();
    }
}