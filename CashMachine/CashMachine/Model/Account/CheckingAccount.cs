// <copyright file="CheckingAccount.cs" company="daniellfeijo.com">
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
    using System.Windows.Forms;

    /// <summary>
    /// The model class for Checking
    /// </summary>
    public class CheckingAccount : Account
    {
        public static int TotalCheckingAccounts { get; private set; }

        public CheckingAccount()
        {
            TotalCheckingAccounts += 1;
        }

        /// <summary>
        /// Method to Withdraw the value
        /// </summary>
        /// <param name="value">Value for withdraw</param>
        public override void Withdraw(double value)
        {
            if (this.Balance < value)
            {
                MessageBox.Show("Value more than the Balance!");
            }
            else
            {
                this.Balance -= value;
            }
        }
    }
}
