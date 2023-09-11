// <copyright file="CheckingAccount.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Bankingsystem
{
    /// <summary>
    /// Checking account has no restrictions in amount withdrawal.
    /// </summary>
    public class CheckingAccount : BankAccount
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckingAccount"/> class.
        /// </summary>
        /// <param name="accountnumber">Accountnumber entered by user as stirng</param>
        public CheckingAccount(string accountnumber)
        {
            this.Accountnumber = accountnumber;
        }

        /// <summary>
        /// Withdraws amount from balance
        /// </summary>
        /// <param name="amount">Amount</param>
        public override void WithdrawAmount(float amount)
        {
            if (this.Balance >= amount)
            {
                this.Balance -= amount;
                Console.WriteLine($"Amount of {amount} is withdrawn and the balance is {this.Balance}");
            }
            else
            {
                Console.WriteLine("Insufficent Balance\n");
            }
        }
    }
}