using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashMachine.Interface
{
    public interface Account
    {
        double Balance { get; }

        void Withdraw(double value);
        void Deposit(double value);
    }
}
