// <copyright file="BankAccount.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Assignment6_Bankingsystem
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
        public string? Accountnumber { get; set; }

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
        /// <returns>Balance amount after withdrawal as float</returns>
        public abstract float WithdrawAmount();

        /// <summary>
        /// Deposite amount method adds the amount deposited to the main balance.
        /// </summary>
        /// <param name="amount">The amount deposited by user.</param>
        /// <returns>The main balance after deposite</returns>
        public float DepositeAmount(float amount)
        {
            this.Balance -= amount;
            return this.Balance;
        }
    }
}