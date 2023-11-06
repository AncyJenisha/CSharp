// <copyright file="ICheckingAccount.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Reflection
{
    /// <summary>
    /// Checking account has no restrictions in amount withdrawal.
    /// </summary>
    public class ICheckingAccount : IBankAccount
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ICheckingAccount"/> class.
        /// </summary>
        public ICheckingAccount()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ICheckingAccount"/> class.
        /// </summary>
        /// <param name="accountNumber">Account Number as string.</param>
        public ICheckingAccount(string accountNumber)
        {
            this.AccountNumber = accountNumber;
        }

        /// <summary>
        /// Gets or sets the amount.
        /// </summary>
        /// <value>Amount as float value</value>
        public float Amount { get; set; }

        /// <summary>
        /// Gets or sets the balance of the account.
        /// </summary>
        /// <value>Balance of the account as float</value>
        public float Balance { get; set; } = 25000F;

        /// <summary>
        /// Gets or sets Account number value as string.
        /// </summary>
        /// <value>Account number as string</value>
        public string? AccountNumber { get; set; }

        /// <summary>
        /// Withdraws amount from balance
        /// </summary>
        /// <param name="amount">Amount</param>
        public void WithdrawAmount(float amount)
        {
            if (this.Balance >= amount)
            {
                this.Balance -= amount;
                Console.WriteLine($"Amount of {amount} is withdrawn and the balance is {this.Balance}\n");
            }
            else
            {
                Console.WriteLine("Insufficent Balance\n");
            }
        }
    }
}