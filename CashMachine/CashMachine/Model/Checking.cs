using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashMachine.Model
{
    class Checking
    {
        public int Numero { get; private set; }
        public double Saldo { get; private set; }
        public Client client { get; private set; }

        public void withdraw(double saldo)
        {
            this.Saldo -= saldo;
        }

    }
}
