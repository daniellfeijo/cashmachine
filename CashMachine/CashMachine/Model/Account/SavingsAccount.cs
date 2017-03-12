// <copyright file="SavingsAccount.cs" company="daniellfeijo.com">
//     daniellfeijo.com. All rights reserved.
// </copyright>
// <author>Daniel Feijo</author>
namespace CashMachine.Model
{
    using Interface.Account;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    /// <summary>
    /// Model of SavingsAccount
    /// </summary>
    public class SavingsAccount : Account, Taxable
    {
        public SavingsAccount(Client client) : base(client)
        {
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
                this.Balance -= value + 0.01;
            }
        }

        public double CalculateTribute()
        {
            return this.Balance * 0.01;
        }
    }
}
