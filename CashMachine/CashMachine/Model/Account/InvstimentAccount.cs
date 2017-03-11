using CashMachine.Interface.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashMachine.Model
{
    class InvstimentAccount : Account, Taxable
    {
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

        public double CalculateTribute()
        {
            return this.Balance * 0.02;
        }
    }
}
