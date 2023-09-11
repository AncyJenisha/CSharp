// <copyright file="Developer.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace EmployeeHierarchy
{
    /// <summary>
    /// Developer object is derived from employee class.
    /// </summary>
    public class Developer : Employee
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Developer"/> class.
        /// </summary>
        /// <param name="developername">Name of the developer as string.</param>
        /// <param name="developersalary">Salary of the developer as string.</param>
        public Developer(string developername, float developersalary)
        {
            this.Name = developername;
            this.Salary = developersalary;
        }

        /// <summary>
        /// Bonus calculates the bonus of the developer from his salary.
        /// </summary>
        /// <returns>Bonus as float.</returns>
        public override float CalculateBonus()
        {
            float bonus = 0.15F * this.Salary;
            return bonus;
        }

        /// <summary>
        /// Prints the details of the Developer
        /// </summary>
        public override void PrintDetails()
        {
            Console.WriteLine($"\nName of the Developer:{this.Name}");
            Console.WriteLine("Postion:Developer");
            Console.WriteLine($"Salary:{this.Salary}");
            Console.WriteLine($"Bonus Amount:{this.CalculateBonus()}\n");
        }
    }
}