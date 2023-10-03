// <copyright file="BankAccount.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Bankingsystem
{
    /// <summary>
    /// BankAccount is the base class.
    /// </summary>
    public abstract class BankAccount
    {
        /// <summary>
        /// Gets or sets Account number value as string.
        /// </summary>
        /// <value>Account number as string</value>
        public string? AccountNumber { get; set; }

        /// <summary>
        /// Gets or sets the amount.
        /// </summary>
        /// <value>Amount as float value</value>
        public float Amount { get; set; }

        /// <summary>
        /// Gets or sets the balance of the account.
        /// </summary>
        /// <value>Balance of the account as float</value>
        public float Balance { get; set; }

        /// <summary>
        /// Method to withdraw the amount.
        /// </summary>
        /// <param name="amount">Amount</param>
        public abstract void WithdrawAmount(float amount);

        /// <summary>
        /// Deposite amount method adds the amount deposited to the main balance.
        /// </summary>
        /// <param name="amount">The amount deposited by user.</param>
        public void DepositAmount(float amount)
        {
            this.Balance += amount;
            Console.WriteLine($"Amount of {amount} is added and the balance is {this.Balance}");
        }

        /// <summary>
        /// This method displays the Account number and Balance.
        /// </summary>
        public void CheckBalance()
        {
            Console.WriteLine($"\nAccount number: {this.AccountNumber}");
            Console.WriteLine($"Balance: {this.Balance}");
        }
    }
}