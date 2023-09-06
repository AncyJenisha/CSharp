// <copyright file="Manager.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Assignment6_Employee
{
    /// <summary>
    /// Manager class has employee class as base.
    /// </summary>
    public class Manager : Employee
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Manager"/> class.
        /// </summary>
        /// <param name="name">Name as string</param>
        /// <param name="salary">Salary as float</param>
        public Manager(string name, float salary)
        {
            this.Salary = salary;
            this.Name = name;
        }

        /// <summary>
        /// Bonus calculates the bonus of the manager.
        /// </summary>
        /// <returns>Bonus as float value</returns>
        public override float Bonus()
        {
            float bonus = 0.25F * this.Salary;
            return bonus;
        }

        /// <summary>
        /// Prints details of the manager.
        /// </summary>
        public override void PrintDetails()
        {
            Console.WriteLine($"Name of the Manager: {this.Name}");
            Console.WriteLine($"Position:Manager");
            Console.WriteLine($"Salary:{this.Salary}");
            Console.WriteLine($"Bonus amount:{this.Bonus()}\n");
        }
    }
}