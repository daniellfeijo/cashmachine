
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashMachine
{
    public class Client
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }

        public Client(string name)
        {
            this.Name = name;
        }


    }
}
