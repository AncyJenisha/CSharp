// <copyright file="SavingsAccount.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Bankingsystem
{
    /// <summary>
    /// SavingsAccount has BankAccount as the base class.
    /// </summary>
    public class SavingsAccount : BankAccount
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SavingsAccount"/> class.
        /// </summary>
        /// <param name="accountnumber">Account number as string.</param>
        public SavingsAccount(string accountnumber)
        {
            this.AccountNumber = accountnumber;
        }

        /// <summary>
        /// Method to withdraw amount with restrictions.
        /// </summary>
        /// <param name="amount">Amount enetered by the user.</param>
        public override void WithdrawAmount(float amount)
        {
            if (this.Balance - amount >= 1000)
            {
                this.Balance -= amount;
                Console.WriteLine($"Amount of {amount} is debited and the balance is {this.Balance}");
            }
            else
            {
                Console.WriteLine("Amount cannot be withdrawn due to insufficent minimum balance\n");
            }
        }
    }
}