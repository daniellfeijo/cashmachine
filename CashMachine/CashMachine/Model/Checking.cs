// <copyright file="Checking.cs" company="daniellfeijo.com">
//     daniellfeijo.com. All rights reserved.
// </copyright>
// <author>Daniel Feijo</author>
namespace CashMachine.Model
{ 
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using CashMachine.Interface;
    
    /// <summary>
    /// The model class for Checking
    /// </summary>
    public class Checking : Account
    {
        /// <summary>
        /// Gets Number of the checking account
        /// </summary>
        public int Numero { get; private set; }
        
        /// <summary>
        /// Gets Balance of checking account
        /// </summary>
        public double Balance { get; private set; }
        
        /// <summary>
        /// Gets Client of checking account
        /// </summary>
        public Client Client { get; private set; }

        /// <summary>
        /// Method to Withdraw the value
        /// </summary>
        /// <param name="value">Value for withdraw</param>
        public void Withdraw(double value)
        {
            this.Balance -= value;
        }

        /// <summary>
        /// Method to Deposit the value
        /// </summary>
        /// <param name="value">Value to deposit</param>
        public void Deposit(double value)
        {
            this.Balance += value;
        }

        /// <summary>
        /// Method to transfer the value
        /// </summary>
        /// <param name="value">Value for transfer</param>
        /// <param name="account">Account that receive the value</param>
        public void Transfer(double value, Account account)
        {
            this.Withdraw(value);
            account.Deposit(value);
        }
    }
}
